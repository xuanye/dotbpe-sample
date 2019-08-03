# tomato 示例程序

---




## 0x 快速开始 QuickStart

### 1. 实现一个HelloWorld的Rpc服务调用


#### Step1 定义一个接口

新建ServiceDefinition,添加引用

```
   dotnet nuget add Tomato.Extra.Castle
   dotnet nuget add Tomato.Extra.MessagePack
   dotnet nuget add Tomato.Rpc
```

然后开始定义接口

这个接口有几个约定：

1. 接口使用`RpcService`特性修饰,参数`ServiceId`保证项目中唯一
2. 接口方法使用`RpcMethod`特性修饰，参数`MessageId`保证本接口中唯一
3. 接口的方法只能是异步方法，并返回 `Task<RpcResult<T>>` 类型的返回值
4. 接口的方法只接收一个参数，多值传递请包装。
5. 参数和返回值T都能被序列化（取决于你使用的序列化方案）

```
[RpcService(1000)]
public interface IQuickStartService
{
    [RpcMethod(1)]
    Task<RpcResult<SayHelloRes>> SayHelloAsync(SayHelloReq req);
}

[DataContract]
public class SayHelloReq{

    [DataMember(Name="name",Order=1)]
    public string Name{get;set;}
}

[DataContract]
public class SayHelloRes{

    [DataMember(Name="greetingWords",Order=1)]
    public string GreetingWords{get;set;}
}

```

#### Step2 实现该服务

>  实现接口只有一个要求，必须继承 `BaseService<TInterService>,TInterService`

```
public class QuickStartService:BaseService<IQuickStartService>,IQuickStartService
{
    public Task<RpcResult<SayHelloRes>> SayHelloAsync(SayHelloReq req){
        var result = new RpcResult<SayHelloRes>{ Data = new SayHelloRes()};

        result.Code = 0;
        result.Data.GreetingWords = $"Hello {req.Name},Welcome to Tomato!";
        return Task.FromResult(result);
    }
}
```

#### Step3 编写服务端Host

```
static void Main(string[] args)
{
    var builder = new HostBuilder()
        .UseRpcServer()
        .UseCastleDynamicProxy()
        .UseMessagePackSerializer() //使用MessagePack编解码
        .BindService<ServiceDefinition.QuickStartService>();//绑定加载的服务   

    //启动，默认绑定5566端口
    builder.RunConsoleAsync().Wait();
}
```

### Step4 编写客户端

```
static void Main(string[] args)
{
        var proxy = ClientProxyFactory.Create()
        .UseCastleDynamicClientProxy()            
        .UseMessagePackSerializer()  //使用MessagePack编解码,和服务端一致
        .UseDefaultChannel($"{IPUtility.GetLocalIntranetIP().MapToIPv4()}:5566")
        .GetClientProxy();


    var service = proxy.Create<IQuickStartService>();

    // 项目中应保证异步到底的调用
    var res = service.SayHelloAsync(new SayHelloReq{Name="Maxi"}).GetAwaiter().GetResult();
    
    Console.WriteLine(res?.Data?.GreetingWords);
    Console.WriteLine("Press any key to exit !");
    Console.ReadKey();
}
```

## 待补充



## 反馈

可以通过 [https://github.com/xuanye/tomato/issues](https://github.com/xuanye/tomato/issues) 反馈问题
另外我创建了一个QQ群：699044833
