QPaperService
--------------------------
	问卷服务
	
## 1. Service Definition


### 1.1 QPaperService.SaveQPaper 
> 20001.1 
>   


#### HTTP调用
+ **接口地址** : /api/qpaper/save  
+ **接口说明** : 保存问卷信息  
+ **请求方式** : POST  



*公共参数不显示，关于公共参数可参考首页说明*

#### 1.1.1 Request


[SaveQPaperReq]  保存问卷的请求

|  字段名  |  类型  |  注释  |   JSON Name  |
| ------------ | ------------ | ------------ | ------------ |
|  qpaper_id  |  int32  |  问卷ID  |   qpaperId   |
|  subject  |  string  |  问卷标题  |   subject   |
|  start_time  |  string  |  问卷开始时间  |   startTime   |
|  end_time  |  string  |  问卷结束时间  |   endTime   |
|  description  |  string  |  注释和说明  |   description   |
|  questions  |  [DTOQuestion](#dtoquestion)  |  问题列表  |   questions   |



#### 1.1.2 Response



[SaveQPaperRsp]  

|  字段名  |  类型  |  注释  |   JSON Name  |
| ------------ | ------------ | ------------ | ------------ |
|  qpaper_id  |  int32  |  保存后的问卷ID  |   qpaperId   |


### 1.2 QPaperService.QueryQPaperList 
> 20001.2 
>   


#### HTTP调用
+ **接口地址** : /api/qpaper/query  
+ **接口说明** : 查询列表  
+ **请求方式** : ALL  



*公共参数不显示，关于公共参数可参考首页说明*

#### 1.2.1 Request


[QueryQPaperReq]  查询问卷的请求

|  字段名  |  类型  |  注释  |   JSON Name  |
| ------------ | ------------ | ------------ | ------------ |
|  query  |  string  |  过滤标题  |   query   |
|  check_role  |  bool  |  是否判断用户权限  |   checkRole   |
|  page  |  int32  |  当前页码  |   page   |
|  rp  |  int32  |  每页记录数  |   rp   |



#### 1.2.2 Response



[QPaperListRsp]  查询问卷的列表

|  字段名  |  类型  |  注释  |   JSON Name  |
| ------------ | ------------ | ------------ | ------------ |
|  list  |  [DTOQPaper](#dtoqpaper)  |  列表  |   list   |
|  total  |  int32  |  记录数，只在page_index = 1 才返回  |   total   |


### 1.3 QPaperService.GetQPaper 
> 20001.3 
>   


#### HTTP调用
+ **接口地址** : /api/qpaper/simple  
+ **接口说明** : 获取问卷信息  
+ **请求方式** : GET  



*公共参数不显示，关于公共参数可参考首页说明*

#### 1.3.1 Request


[GetQPaperReq]  获取单个问卷的请求

|  字段名  |  类型  |  注释  |   JSON Name  |
| ------------ | ------------ | ------------ | ------------ |
|  qpaper_id  |  int32  |  问卷ID  |   qpaperId   |
|  check_role  |  bool  |  是否判断用户权限  |   checkRole   |



#### 1.3.2 Response



[QPaperRsp]  包括单个问卷信息的响应

|  字段名  |  类型  |  注释  |   JSON Name  |
| ------------ | ------------ | ------------ | ------------ |
|  qpaper_id  |  int32  |  问卷ID  |   qpaperId   |
|  subject  |  string  |  问卷标题  |   subject   |
|  start_time  |  string  |  问卷开始时间  |   startTime   |
|  end_time  |  string  |  问卷结束时间  |   endTime   |
|  description  |  string  |  注释和说明  |   description   |
|  create_user_id  |  string  |  注释  |   createUserId   |


### 1.4 QPaperService.GetQPaperFull 
> 20001.4 
>   


#### HTTP调用
+ **接口地址** : /api/qpaper/get  
+ **接口说明** : 获取问卷详情信息  
+ **请求方式** : GET  



*公共参数不显示，关于公共参数可参考首页说明*

#### 1.4.1 Request


[GetQPaperReq]  获取单个问卷的请求

|  字段名  |  类型  |  注释  |   JSON Name  |
| ------------ | ------------ | ------------ | ------------ |
|  qpaper_id  |  int32  |  问卷ID  |   qpaperId   |
|  check_role  |  bool  |  是否判断用户权限  |   checkRole   |



#### 1.4.2 Response



[QPaperFullRsp]  

|  字段名  |  类型  |  注释  |   JSON Name  |
| ------------ | ------------ | ------------ | ------------ |
|  qpaper  |  [DTOQPaperWithQuestion](#dtoqpaperwithquestion)  |  问卷  |   qpaper   |


### 1.5 QPaperService.AddAPaperCount 
> 20001.5 
>   



*公共参数不显示，关于公共参数可参考首页说明*

#### 1.5.1 Request


[AddAPaperReq]  

|  字段名  |  类型  |  注释  |   JSON Name  |
| ------------ | ------------ | ------------ | ------------ |
|  qpaper_id  |  int32  |    |   qpaperId   |
|  count  |  int32  |    |   count   |



#### 1.5.2 Response



[VoidRsp]  只返回默认的返回

|  字段名  |  类型  |  注释  |   JSON Name  |
| ------------ | ------------ | ------------ | ------------ |




## 2. Message Definition

### <span id="saveqpaperreq">SaveQPaperReq</span> 
> 保存问卷的请求  

| 字段名     | 类型   |  注释  |  JSON Name  |
| --------   | -----  | ----  | ----  |
|  client_ip  |  string  |  用户端IP  |   clientIp   |
|  identity  |  string  |  用户标识  |   identity   |
|  x_request_id  |  string  |  请求的唯一标识，用于服务间传递  |   xRequestId   |
|  qpaper_id  |  int32  |  问卷ID  |   qpaperId   |
|  subject  |  string  |  问卷标题  |   subject   |
|  start_time  |  string  |  问卷开始时间  |   startTime   |
|  end_time  |  string  |  问卷结束时间  |   endTime   |
|  description  |  string  |  注释和说明  |   description   |
|  questions  |  [DTOQuestion](#dtoquestion)  |  问题列表  |   questions   |

### <span id="dtoquestion">DTOQuestion</span> 
>   

| 字段名     | 类型   |  注释  |  JSON Name  |
| --------   | -----  | ----  | ----  |
|  id  |  string  |  问题ID  |   id   |
|  topic  |  string  |  标题  |   topic   |
|  paper_id  |  int32  |  问卷ID  |   paperId   |
|  question_type  |  [QuestionType](#questiontype)  |  问题类型  |   questionType   |
|  item_detail  |  string  |  问题详情  |   itemDetail   |
|  extend_input  |  bool  |  是否自定义输入，只有在单选题 有效  |   extendInput   |

### <span id="saveqpaperrsp">SaveQPaperRsp</span> 
>   

| 字段名     | 类型   |  注释  |  JSON Name  |
| --------   | -----  | ----  | ----  |
|  return_message  |  string  |  返回错误信息  |   returnMessage   |
|  qpaper_id  |  int32  |  保存后的问卷ID  |   qpaperId   |

### <span id="queryqpaperreq">QueryQPaperReq</span> 
> 查询问卷的请求  

| 字段名     | 类型   |  注释  |  JSON Name  |
| --------   | -----  | ----  | ----  |
|  client_ip  |  string  |  用户端IP  |   clientIp   |
|  identity  |  string  |  用户标识  |   identity   |
|  x_request_id  |  string  |  请求的唯一标识，用于服务间传递  |   xRequestId   |
|  query  |  string  |  过滤标题  |   query   |
|  check_role  |  bool  |  是否判断用户权限  |   checkRole   |
|  page  |  int32  |  当前页码  |   page   |
|  rp  |  int32  |  每页记录数  |   rp   |

### <span id="qpaperlistrsp">QPaperListRsp</span> 
> 查询问卷的列表  

| 字段名     | 类型   |  注释  |  JSON Name  |
| --------   | -----  | ----  | ----  |
|  return_message  |  string  |  返回错误信息  |   returnMessage   |
|  list  |  [DTOQPaper](#dtoqpaper)  |  列表  |   list   |
|  total  |  int32  |  记录数，只在page_index = 1 才返回  |   total   |

### <span id="dtoqpaper">DTOQPaper</span> 
> 简化的QPaper 消息  

| 字段名     | 类型   |  注释  |  JSON Name  |
| --------   | -----  | ----  | ----  |
|  qpaper_id  |  int32  |  问卷ID  |   qpaperId   |
|  subject  |  string  |  问卷标题  |   subject   |
|  start_time  |  string  |  问卷开始时间  |   startTime   |
|  end_time  |  string  |  问卷结束时间  |   endTime   |
|  description  |  string  |  注释和说明  |   description   |
|  create_user_id  |  string  |  用户  |   createUserId   |
|  apaper_count  |  int32  |  答卷数  |   apaperCount   |

### <span id="getqpaperreq">GetQPaperReq</span> 
> 获取单个问卷的请求  

| 字段名     | 类型   |  注释  |  JSON Name  |
| --------   | -----  | ----  | ----  |
|  client_ip  |  string  |  用户端IP  |   clientIp   |
|  identity  |  string  |  用户标识  |   identity   |
|  x_request_id  |  string  |  请求的唯一标识，用于服务间传递  |   xRequestId   |
|  qpaper_id  |  int32  |  问卷ID  |   qpaperId   |
|  check_role  |  bool  |  是否判断用户权限  |   checkRole   |

### <span id="qpaperrsp">QPaperRsp</span> 
> 包括单个问卷信息的响应  

| 字段名     | 类型   |  注释  |  JSON Name  |
| --------   | -----  | ----  | ----  |
|  return_message  |  string  |  返回错误信息  |   returnMessage   |
|  qpaper_id  |  int32  |  问卷ID  |   qpaperId   |
|  subject  |  string  |  问卷标题  |   subject   |
|  start_time  |  string  |  问卷开始时间  |   startTime   |
|  end_time  |  string  |  问卷结束时间  |   endTime   |
|  description  |  string  |  注释和说明  |   description   |
|  create_user_id  |  string  |  注释  |   createUserId   |

### <span id="qpaperfullrsp">QPaperFullRsp</span> 
>   

| 字段名     | 类型   |  注释  |  JSON Name  |
| --------   | -----  | ----  | ----  |
|  return_message  |  string  |  返回错误信息  |   returnMessage   |
|  qpaper  |  [DTOQPaperWithQuestion](#dtoqpaperwithquestion)  |  问卷  |   qpaper   |

### <span id="dtoqpaperwithquestion">DTOQPaperWithQuestion</span> 
>   

| 字段名     | 类型   |  注释  |  JSON Name  |
| --------   | -----  | ----  | ----  |
|  qpaper_id  |  int32  |  问卷ID  |   qpaperId   |
|  subject  |  string  |  问卷标题  |   subject   |
|  start_time  |  string  |  问卷开始时间  |   startTime   |
|  end_time  |  string  |  问卷结束时间  |   endTime   |
|  description  |  string  |  注释和说明  |   description   |
|  apaper_count  |  int32  |  答卷数  |   apaperCount   |
|  questions  |  [DTOQuestion](#dtoquestion)  |  问题列表  |   questions   |

### <span id="dtoquestion">DTOQuestion</span> 
>   

| 字段名     | 类型   |  注释  |  JSON Name  |
| --------   | -----  | ----  | ----  |
|  id  |  string  |  问题ID  |   id   |
|  topic  |  string  |  标题  |   topic   |
|  paper_id  |  int32  |  问卷ID  |   paperId   |
|  question_type  |  [QuestionType](#questiontype)  |  问题类型  |   questionType   |
|  item_detail  |  string  |  问题详情  |   itemDetail   |
|  extend_input  |  bool  |  是否自定义输入，只有在单选题 有效  |   extendInput   |

### <span id="addapaperreq">AddAPaperReq</span> 
>   

| 字段名     | 类型   |  注释  |  JSON Name  |
| --------   | -----  | ----  | ----  |
|  client_ip  |  string  |  用户端IP  |   clientIp   |
|  identity  |  string  |  用户标识  |   identity   |
|  x_request_id  |  string  |  请求的唯一标识，用于服务间传递  |   xRequestId   |
|  qpaper_id  |  int32  |    |   qpaperId   |
|  count  |  int32  |    |   count   |

### <span id="voidrsp">VoidRsp</span> 
> 只返回默认的返回  

| 字段名     | 类型   |  注释  |  JSON Name  |
| --------   | -----  | ----  | ----  |
|  return_message  |  string  |  返回错误信息  |   returnMessage   |
