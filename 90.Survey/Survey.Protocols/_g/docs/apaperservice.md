APaperService
--------------------------
	答卷服务
	
## 1. Service Definition


### 1.1 APaperService.SaveAPaper 
> 20002.1 
>   


#### HTTP调用
+ **接口地址** : /api/apaper/save  
+ **接口说明** : 保存答卷信息  
+ **请求方式** : POST  



*公共参数不显示，关于公共参数可参考首页说明*

#### 1.1.1 Request


[SaveAPaperReq]  什么字段都没有，请求

|  字段名  |  类型  |  注释  |   JSON Name  |
| ------------ | ------------ | ------------ | ------------ |
|  qpaper_id  |  int32  |    |   qpaperId   |
|  user_id  |  string  |  答卷用户ID  |   userId   |
|  remark  |  string  |    |   remark   |
|  answers  |  [DTOAnswer](#dtoanswer)  |  答案信息  |   answers   |



#### 1.1.2 Response



[SaveAPaperRsp]  

|  字段名  |  类型  |  注释  |   JSON Name  |
| ------------ | ------------ | ------------ | ------------ |
|  apaper_id  |  int32  |  保存后的问卷ID  |   apaperId   |


### 1.2 APaperService.QueryAPaperList 
> 20002.2 
>   


#### HTTP调用
+ **接口地址** : /api/apaper/query  
+ **接口说明** : 查询答卷信息  
+ **请求方式** : ALL  



*公共参数不显示，关于公共参数可参考首页说明*

#### 1.2.1 Request


[QueryAPaperReq]  查询问卷的请求

|  字段名  |  类型  |  注释  |   JSON Name  |
| ------------ | ------------ | ------------ | ------------ |
|  qtext  |  string  |  主题 模糊搜索  |   qtext   |
|  qpaper_id  |  int32  |  问卷ID  |   qpaperId   |
|  page  |  int32  |  分页索引  |   page   |
|  rp  |  int32  |  每页记录数  |   rp   |
|  check_role  |  bool  |  检查角色  |   checkRole   |



#### 1.2.2 Response



[APaperListRsp]  查询问卷的列表

|  字段名  |  类型  |  注释  |   JSON Name  |
| ------------ | ------------ | ------------ | ------------ |
|  list  |  [DTOAPaper](#dtoapaper)  |  答卷列表  |   list   |
|  total  |  int32  |  每页的记录数  |   total   |


### 1.3 APaperService.GetAPaper 
> 20002.3 
>   


#### HTTP调用
+ **接口地址** : /api/apaper/get  
+ **接口说明** : 获取答卷信息  
+ **请求方式** : GET  



*公共参数不显示，关于公共参数可参考首页说明*

#### 1.3.1 Request


[GetAPaperReq]  获取单个问卷的请求

|  字段名  |  类型  |  注释  |   JSON Name  |
| ------------ | ------------ | ------------ | ------------ |
|  paper_id  |  int32  |  答卷ID  |   paperId   |
|  check_role  |  bool  |  是否校验权限  |   checkRole   |



#### 1.3.2 Response



[APaperRsp]  包括单个问卷信息的响应

|  字段名  |  类型  |  注释  |   JSON Name  |
| ------------ | ------------ | ------------ | ------------ |
|  apaper  |  [DTOAPaperWithAnswers](#dtoapaperwithanswers)  |    |   apaper   |
|  qpaper  |  [DTOQPaperWithQuestion](#dtoqpaperwithquestion)  |    |   qpaper   |


### 1.4 APaperService.GetAPaperSta 
> 20002.4 
>   



*公共参数不显示，关于公共参数可参考首页说明*

#### 1.4.1 Request


[GetAPaperStaDetailReq]  

|  字段名  |  类型  |  注释  |   JSON Name  |
| ------------ | ------------ | ------------ | ------------ |
|  qpaper_id  |  int32  |  问卷ID  |   qpaperId   |



#### 1.4.2 Response



[APaperStaDetailRsp]  

|  字段名  |  类型  |  注释  |   JSON Name  |
| ------------ | ------------ | ------------ | ------------ |
|  sta_detail  |  [APaperStaDetail](#apaperstadetail)  |  统计信息  |   staDetail   |




## 2. Message Definition

### <span id="saveapaperreq">SaveAPaperReq</span> 
> 什么字段都没有，请求  

| 字段名     | 类型   |  注释  |  JSON Name  |
| --------   | -----  | ----  | ----  |
|  client_ip  |  string  |  用户端IP  |   clientIp   |
|  identity  |  string  |  用户标识  |   identity   |
|  x_request_id  |  string  |  请求的唯一标识，用于服务间传递  |   xRequestId   |
|  qpaper_id  |  int32  |    |   qpaperId   |
|  user_id  |  string  |  答卷用户ID  |   userId   |
|  remark  |  string  |    |   remark   |
|  answers  |  [DTOAnswer](#dtoanswer)  |  答案信息  |   answers   |

### <span id="dtoanswer">DTOAnswer</span> 
>   

| 字段名     | 类型   |  注释  |  JSON Name  |
| --------   | -----  | ----  | ----  |
|  answer_id  |  string  |    |   answerId   |
|  apaper_id  |  int32  |    |   apaperId   |
|  question_id  |  string  |    |   questionId   |
|  objective_answer  |  int32  |    |   objectiveAnswer   |
|  subjective_answer  |  string  |    |   subjectiveAnswer   |

### <span id="saveapaperrsp">SaveAPaperRsp</span> 
>   

| 字段名     | 类型   |  注释  |  JSON Name  |
| --------   | -----  | ----  | ----  |
|  return_message  |  string  |  返回错误信息  |   returnMessage   |
|  apaper_id  |  int32  |  保存后的问卷ID  |   apaperId   |

### <span id="queryapaperreq">QueryAPaperReq</span> 
> 查询问卷的请求  

| 字段名     | 类型   |  注释  |  JSON Name  |
| --------   | -----  | ----  | ----  |
|  client_ip  |  string  |  用户端IP  |   clientIp   |
|  identity  |  string  |  用户标识  |   identity   |
|  x_request_id  |  string  |  请求的唯一标识，用于服务间传递  |   xRequestId   |
|  qtext  |  string  |  主题 模糊搜索  |   qtext   |
|  qpaper_id  |  int32  |  问卷ID  |   qpaperId   |
|  page  |  int32  |  分页索引  |   page   |
|  rp  |  int32  |  每页记录数  |   rp   |
|  check_role  |  bool  |  检查角色  |   checkRole   |

### <span id="apaperlistrsp">APaperListRsp</span> 
> 查询问卷的列表  

| 字段名     | 类型   |  注释  |  JSON Name  |
| --------   | -----  | ----  | ----  |
|  return_message  |  string  |  返回错误信息  |   returnMessage   |
|  list  |  [DTOAPaper](#dtoapaper)  |  答卷列表  |   list   |
|  total  |  int32  |  每页的记录数  |   total   |

### <span id="dtoapaper">DTOAPaper</span> 
>   

| 字段名     | 类型   |  注释  |  JSON Name  |
| --------   | -----  | ----  | ----  |
|  apaper_id  |  int32  |    |   apaperId   |
|  qpaper_id  |  int32  |    |   qpaperId   |
|  qpaper_subject  |  string  |    |   qpaperSubject   |
|  qpaper_user_id  |  string  |    |   qpaperUserId   |
|  user_id  |  string  |    |   userId   |
|  create_time  |  string  |    |   createTime   |
|  remark  |  string  |    |   remark   |

### <span id="getapaperreq">GetAPaperReq</span> 
> 获取单个问卷的请求  

| 字段名     | 类型   |  注释  |  JSON Name  |
| --------   | -----  | ----  | ----  |
|  client_ip  |  string  |  用户端IP  |   clientIp   |
|  identity  |  string  |  用户标识  |   identity   |
|  x_request_id  |  string  |  请求的唯一标识，用于服务间传递  |   xRequestId   |
|  paper_id  |  int32  |  答卷ID  |   paperId   |
|  check_role  |  bool  |  是否校验权限  |   checkRole   |

### <span id="apaperrsp">APaperRsp</span> 
> 包括单个问卷信息的响应  

| 字段名     | 类型   |  注释  |  JSON Name  |
| --------   | -----  | ----  | ----  |
|  return_message  |  string  |  返回错误信息  |   returnMessage   |
|  apaper  |  [DTOAPaperWithAnswers](#dtoapaperwithanswers)  |    |   apaper   |
|  qpaper  |  [DTOQPaperWithQuestion](#dtoqpaperwithquestion)  |    |   qpaper   |

### <span id="dtoapaperwithanswers">DTOAPaperWithAnswers</span> 
>   

| 字段名     | 类型   |  注释  |  JSON Name  |
| --------   | -----  | ----  | ----  |
|  apaper_id  |  int32  |    |   apaperId   |
|  qpaper_id  |  int32  |    |   qpaperId   |
|  user_id  |  string  |    |   userId   |
|  create_time  |  string  |    |   createTime   |
|  remark  |  string  |    |   remark   |
|  answers  |  [DTOAnswer](#dtoanswer)  |  答案信息  |   answers   |

### <span id="dtoanswer">DTOAnswer</span> 
>   

| 字段名     | 类型   |  注释  |  JSON Name  |
| --------   | -----  | ----  | ----  |
|  answer_id  |  string  |    |   answerId   |
|  apaper_id  |  int32  |    |   apaperId   |
|  question_id  |  string  |    |   questionId   |
|  objective_answer  |  int32  |    |   objectiveAnswer   |
|  subjective_answer  |  string  |    |   subjectiveAnswer   |

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

### <span id="getapaperstadetailreq">GetAPaperStaDetailReq</span> 
>   

| 字段名     | 类型   |  注释  |  JSON Name  |
| --------   | -----  | ----  | ----  |
|  client_ip  |  string  |  用户端IP  |   clientIp   |
|  identity  |  string  |  用户标识  |   identity   |
|  x_request_id  |  string  |  请求的唯一标识，用于服务间传递  |   xRequestId   |
|  qpaper_id  |  int32  |  问卷ID  |   qpaperId   |

### <span id="apaperstadetailrsp">APaperStaDetailRsp</span> 
>   

| 字段名     | 类型   |  注释  |  JSON Name  |
| --------   | -----  | ----  | ----  |
|  return_message  |  string  |  返回错误信息  |   returnMessage   |
|  sta_detail  |  [APaperStaDetail](#apaperstadetail)  |  统计信息  |   staDetail   |

### <span id="apaperstadetail">APaperStaDetail</span> 
>   

| 字段名     | 类型   |  注释  |  JSON Name  |
| --------   | -----  | ----  | ----  |
|  question_id  |  string  |  问题id  |   questionId   |
|  oa  |  int32  |  答案统计信息  |   oa   |
