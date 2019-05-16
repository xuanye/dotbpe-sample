APaperFacadeService
--------------------------
	答卷外观服务
	
## 1. Service Definition


### 1.1 APaperFacadeService.GetAPaperSta 
> 10002.1 
> 获取答卷统计  


#### HTTP调用
+ **接口地址** : /api/qpaper/sta  
+ **接口说明** : 获取问卷统计信息  
+ **请求方式** : GET  



*公共参数不显示，关于公共参数可参考首页说明*

#### 1.1.1 Request


[GetQPaperStaReq]  

|  字段名  |  类型  |  注释  |   JSON Name  |
| ------------ | ------------ | ------------ | ------------ |
|  qpaper_id  |  int32  |    |   qpaperId   |



#### 1.1.2 Response



[QPaperStaRsp]  

|  字段名  |  类型  |  注释  |   JSON Name  |
| ------------ | ------------ | ------------ | ------------ |
|  qpaper  |  [DTOQPaperWithQuestion](#dtoqpaperwithquestion)  |    |   qpaper   |
|  sta_detail  |  [APaperStaDetail](#apaperstadetail)  |    |   staDetail   |




## 2. Message Definition

### <span id="getqpaperstareq">GetQPaperStaReq</span> 
>   

| 字段名     | 类型   |  注释  |  JSON Name  |
| --------   | -----  | ----  | ----  |
|  client_ip  |  string  |  用户端IP  |   clientIp   |
|  identity  |  string  |  用户标识  |   identity   |
|  x_request_id  |  string  |  请求的唯一标识，用于服务间传递  |   xRequestId   |
|  qpaper_id  |  int32  |    |   qpaperId   |

### <span id="qpaperstarsp">QPaperStaRsp</span> 
>   

| 字段名     | 类型   |  注释  |  JSON Name  |
| --------   | -----  | ----  | ----  |
|  return_message  |  string  |  返回错误信息  |   returnMessage   |
|  qpaper  |  [DTOQPaperWithQuestion](#dtoqpaperwithquestion)  |    |   qpaper   |
|  sta_detail  |  [APaperStaDetail](#apaperstadetail)  |    |   staDetail   |

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

### <span id="apaperstadetail">APaperStaDetail</span> 
>   

| 字段名     | 类型   |  注释  |  JSON Name  |
| --------   | -----  | ----  | ----  |
|  question_id  |  string  |  问题id  |   questionId   |
|  oa  |  int32  |  答案统计信息  |   oa   |
