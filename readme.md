# dotbpe

---


dotbpe ![](https://travis-ci.org/xuanye/dotbpe.svg?branch=master)
-------------
dotbpe一套基于dotnet core平台的业务流程处理引擎，力求解决项目开发中，关于服务端开发的各种通用问题，如远程过程调用（Rpc），延迟队列（DelayTaskQueue），任务调度（TaskManage），网关（Gateway）等问题。

dotbpe rpc 项目就是其中的Rpc部分的实现，底层的通讯部份基于Peach（基于DotNetty封装，支持自定义协议的Socket类库）。该组件的目标并不是只是解决Rpc的问题，同时考虑到开发调式的便利性，支持本地服务和远端无差别开发，在编码时不用考虑服务是如何部署的（分布式或者单机部署），可以在项目初期流量较少时，只部署单台或者做简单的负载均衡即可，当项目流量增加后可通过配置和部署方案，不需要修改任何代码来实现快速扩容。

dotbpe rpc 支持两种开发模式，一种类似于Dubbo的定义接口的方式Rpc服务，另外一种支持像gRpc方式，预先定义服务描述文件（.proto）来定义Rpc服务.




## 0x 快速开始 QuickStart

### 1. 实现一个HelloWorld的Rpc服务调用


#### Step1 定义一个接口

新建ServiceDefinition,添加引用

```
   dotnet nuget add DotBPE.Extra.Castle
   dotnet nuget add DotBPE.Extra.MessagePack
   dotnet nuget add DotBPE.Rpc
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
        result.Data.GreetingWords = $"Hello {req.Name},Welcome to DotBPE!";
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

可以通过 [https://github.com/dotbpe/dotbpe/issues](https://github.com/dotbpe/dotbpe/issues) 反馈问题
另外我创建了一个QQ群：
![](http://ww1.sinaimg.cn/large/697065c1ly1fnsy1a8apgj206a082t8y.jpg)
