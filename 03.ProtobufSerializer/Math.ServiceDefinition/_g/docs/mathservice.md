MathService
--------------------------
	数学服务
	
## 1. Service Definition


### 1.1 MathService.Sum 
> 100.1 
> 加法方法，不用添加Async后缀  



*公共参数不显示，关于公共参数可参考首页说明*

#### 1.1.1 Request


[SumReq]  加法函数请求参数

|  字段名  |  类型  |  注释  |   JSON Name  |
| ------------ | ------------ | ------------ | ------------ |
|  a  |  int32  |  参数A  |   a   |
|  b  |  int32  |  参数B  |   b   |



#### 1.1.2 Response



[SumRes]  加法参数相应

|  字段名  |  类型  |  注释  |   JSON Name  |
| ------------ | ------------ | ------------ | ------------ |
|  total  |  int32  |  总和  |   total   |




## 2. Message Definition

### <span id="sumreq">SumReq</span> 
> 加法函数请求参数  

| 字段名     | 类型   |  注释  |  JSON Name  |
| --------   | -----  | ----  | ----  |
|  a  |  int32  |  参数A  |   a   |
|  b  |  int32  |  参数B  |   b   |

### <span id="sumres">SumRes</span> 
> 加法参数相应  

| 字段名     | 类型   |  注释  |  JSON Name  |
| --------   | -----  | ----  | ----  |
|  total  |  int32  |  总和  |   total   |
