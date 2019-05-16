HTTP API 接口文档一览  
--------------------------  
## 1 接口说明  
### 1.1 公共参数  
	绝大多数接口中都包含公共参数，公共参数有App内置传递，公共参数如下所示 
|  字段名  |  类型  |  注释  |  
| ------------ | ------------ | ------------ |  
|  clientIp    |  string  |  用户端IP，服务自动获取，传递也无效   |  
|  identity    |  string  |  用户标识，服务自动获取，传递也无效  |  
|  xRequestId  |  string  |  请求的唯一标识，用于服务间传递，HEAD中传递X-REQUEST-ID 传递，不传则自动创建  |  


以上为DotBPE默认建议的公共参数，建议在接口入参定义，不同项目还需定义额外的公共参数，如手机App客户端项目，如下表格说是

|  字段名  |  类型  |  注释  |  
| ------------ | ------------ | ------------ |  
|  deviceOs    |  string  |  设备操作系统,例如ios9.3  | 
|  srcCode     |  int32   |  客户端来源 4=Android 6 =h5 7=web 8=iso 11=window客户端  |  
|  appVersion  |  int32   |  app版本（纯数字类型）  |  
|  deviceName  |  string  |  设备名称  |  
|  deviceId    |  string  |  设备编号  |  
   


### 1.2 返回格式  
> 所有的http接口都包括固定的返回格式，如下所示 

```json
 {"returnCode": 0,"returnMessage": "success","data": {}} 
``` 

其中data 节点中的数据为返回的业务数据，调用者通过`returnCode` 来判断是否调用正确 

##  2 服务一览表  


### 2.1 APaperFacadeService
>  答卷外观服务

| 序号 |  服务名  |  消息ID  |  请求地址  |  说明  |  
| ------------| ------------ | ------------ | ------------ | ------------ |
| 1 | GetAPaperSta |  10002.1  |  /api/qpaper/sta  |  获取答卷统计  |

### 2.2 APaperService
>  答卷服务

| 序号 |  服务名  |  消息ID  |  请求地址  |  说明  |  
| ------------| ------------ | ------------ | ------------ | ------------ |
| 1 | SaveAPaper |  20002.1  |  /api/apaper/save  |  无说明  |
| 2 | QueryAPaperList |  20002.2  |  /api/apaper/query  |  无说明  |
| 3 | GetAPaper |  20002.3  |  /api/apaper/get  |  无说明  |

### 2.3 QPaperService
>  问卷服务

| 序号 |  服务名  |  消息ID  |  请求地址  |  说明  |  
| ------------| ------------ | ------------ | ------------ | ------------ |
| 1 | SaveQPaper |  20001.1  |  /api/qpaper/save  |  无说明  |
| 2 | QueryQPaperList |  20001.2  |  /api/qpaper/query  |  无说明  |
| 3 | GetQPaper |  20001.3  |  /api/qpaper/simple  |  无说明  |
| 4 | GetQPaperFull |  20001.4  |  /api/qpaper/get  |  无说明  |

### 2.4 UserService
>  用户服务

| 序号 |  服务名  |  消息ID  |  请求地址  |  说明  |  
| ------------| ------------ | ------------ | ------------ | ------------ |
| 1 | Register |  20003.1  |  /api/user/register  |  注册  |
| 2 | Login |  20003.2  |  /api/gate/login  |  登录  |
| 3 | Edit |  20003.3  |  /api/user/save  |  修改用户信息  |
| 5 | CheckLogin |  20003.5  |  /api/gate/check  |  获取用户信息  |
