<p></p>
<p></p>
<p align="center">
<img src="https://ftp.bmp.ovh/imgs/2021/06/351eeccfadc07014.png" width = "100" height = "100" alt="图片名称" align=center />
</p>

 <div align="center"> 
  
[![NuGet version (RRQMSocket.Http)](https://img.shields.io/nuget/v/RRQMSocket.Http.svg?style=flat-square)](https://www.nuget.org/packages/RRQMSocket.Http/)
[![License](https://img.shields.io/badge/license-Apache%202-4EB1BA.svg)](https://www.apache.org/licenses/LICENSE-2.0.html)
[![Download](https://img.shields.io/nuget/dt/RRQMSocket.Http)](https://www.nuget.org/packages/RRQMSocket.Http/)
<a href="https://jq.qq.com/?_wv=1027&k=gN7UL4fw">
<img src="https://img.shields.io/badge/QQ群-234762506-red" alt="QQ">
</a>
</div>  

<div align="center">

落霞与孤鹜齐飞 秋水共长天一色

</div>

## 💿描述
| 名称|地址 |描述|
|---|---|---|
| [![NuGet version (RRQMSocket.WebSocket)](https://img.shields.io/nuget/v/RRQMSocket.WebSocket.svg?label=RRQMSocket.WebSocket)](https://www.nuget.org/packages/rrqmsocket.websocket)|[Gitee](https://gitee.com/dotnetchina/RRQMSocket)<br>[Github](https://github.com/RRQM/RRQMSocket) |  RRQMSocket.WebSocket是一个高效，超轻量级的WebSocket框架。<br>它包含了Service和Client两大组件，支持Ssl，同时定义了文本、二进制或<br>其他类型数据的快捷发送、分片发送接口，可与js等任意WebSocket组件交互|
| [![NuGet version (RRQMSocket.Http)](https://img.shields.io/nuget/v/RRQMSocket.Http.svg?label=RRQMSocket.Http)](https://www.nuget.org/packages/rrqmsocket.http)|[Gitee](https://gitee.com/dotnetchina/RRQMSocket)<br>[Github](https://github.com/RRQM/RRQMSocket)  |  RRQMSocket.Http是一个能够简单解析Http的服务组件，<br>能够快速响应Http服务请求。支持大文件传输，多线程下载等。<br>但是该组件并不能替代Web后端，仅仅是一个轻量级的Http服务器。|

## 🎀依赖、扩展库
| 名称|地址 |描述|
|---|---|---|
|[![NuGet version (RRQMSocket.RPC)](https://img.shields.io/nuget/v/RRQMSocket.RPC.svg?label=RRQMSocket.RPC)](https://www.nuget.org/packages/rrqmsocket.rpc)|[Gitee](https://gitee.com/RRQM_Home/rrqmsocket.rpc)<br>[Github](https://github.com/RRQM/RRQMSocket.RPC) |RPC是一个超轻量、高性能、可扩展的微服务管理平台框架，<br>目前已完成开发**RRQMRPC**、**XmlRpc**、**JsonRpc**、**WebApi**部分。<br> **RRQMRPC**部分使用RRQM专属协议，支持客户端**异步调用**，<br>服务端**异步触发**、以及**out**和**ref**关键字，**函数回调**等。<br>在调用效率上也是非常强悍，在调用空载函数，且返回状态时，<br>**10w**次调用仅用时**3.8**秒，不返回状态用时**0.9**秒。<br>其他协议调用性能详看性能评测。
|[![NuGet version (RRQMSocket.RPC.XmlRpc)](https://img.shields.io/nuget/v/RRQMSocket.RPC.XmlRpc.svg?label=RRQMSocket.RPC.XmlRpc)](https://www.nuget.org/packages/rrqmsocket.rpc.xmlrpc)|[Gitee](https://gitee.com/RRQM_Home/rrqmsocket.rpc)<br>[Github](https://github.com/RRQM/RRQMSocket.RPC) | XmlRpc是一个扩展于RRQMSocket.RPC的XmlRpc组件，可以通过<br>该组件创建XmlRpc服务解析器，完美支持XmlRpc数据类型，类型嵌套，<br>Array等，也能与CookComputing.XmlRpcV2完美对接。<br>不限Web，Android等平台。|
| [![NuGet version (RRQMSocket.RPC.JsonRpc)](https://img.shields.io/nuget/v/RRQMSocket.RPC.JsonRpc.svg?label=RRQMSocket.RPC.JsonRpc)](https://www.nuget.org/packages/rrqmsocket.rpc.jsonrpc)|[Gitee](https://gitee.com/RRQM_Home/rrqmsocket.rpc)<br>[Github](https://github.com/RRQM/RRQMSocket.RPC) | JsonRpc是一个扩展于RRQMSocket.RPC的JsonRpc组件，<br>可以通过该组件创建JsonRpc服务解析器，支持JsonRpc全部功能，可与Web，Android等平台无缝对接。|
|[![NuGet version (RRQMSocket.RPC.WebApi)](https://img.shields.io/nuget/v/RRQMSocket.RPC.WebApi.svg?label=RRQMSocket.RPC.WebApi)](https://www.nuget.org/packages/rrqmsocket.rpc.webapi)|[Gitee](https://gitee.com/RRQM_Home/rrqmsocket.rpc)<br>[Github](https://github.com/RRQM/RRQMSocket.RPC) | WebApi是一个扩展于RRQMSocket.RPC的WebApi组件，可以通过<br>该组件创建WebApi服务解析器，让桌面端、Web端、移动端可以<br>跨语言调用RPC函数。功能支持路由、Get传参、Post传参等。|
| [![NuGet version (RRQMCore)](https://img.shields.io/nuget/v/RRQMCore.svg?label=RRQMCore)](https://www.nuget.org/packages/RRQMCore)|[Gitee](https://gitee.com/dotnetchina/RRQMSocket)<br>[Github](https://github.com/RRQM/RRQMSocket) | RRQMCore是为RRQM系提供基础服务功能的库，其中包含：<br>**内存池**、**对象池**、**等待逻辑池**、**AppMessenger**、**3DES加密**、<br>**Xml快速存储**、**运行时间测量器**、**文件快捷操作**、<br>**高性能序列化器**、**规范日志接口**等。 |
|[![NuGet version (RRQMSocket)](https://img.shields.io/nuget/v/RRQMSocket.svg?label=RRQMSocket)](https://www.nuget.org/packages/RRQMSocket/)|[Gitee](https://gitee.com/dotnetchina/RRQMSocket)<br>[Github](https://github.com/RRQM/RRQMSocket)| RRQMSocket是一个整合性的、超轻量级的网络通信框架。<br>包含了TCP、UDP、Ssl、Channel、Protocol、Token、<br>租户模式等一系列的通信模块。其扩展组件包含：WebSocket、<br>大文件传输、RPC、WebApi、XmlRpc、JsonRpc等内容|
|[![NuGet version](https://img.shields.io/nuget/v/RRQMSocketFramework.svg?label=RRQMSocketFramework)](https://www.nuget.org/packages/RRQMSocketFramework/)|[Gitee](https://gitee.com/dotnetchina/RRQMSocket)<br>[Github](https://github.com/RRQM/RRQMSocket) |**RRQMSocketFramework**是RRQMSocket系列的增强企业版，<br>两者在基础功能上没有区别，但是在扩展功能上有一定差异性，<br>例如RPC中的EventBus、文件传输中的限速功能等，<br>具体差异请看[RRQM商业运营](https://gitee.com/RRQM_OS/RRQM/wikis/%E5%95%86%E4%B8%9A%E8%BF%90%E8%90%A5)|
| [![NuGet version (RRQMSocket.FileTransfer)](https://img.shields.io/nuget/v/RRQMSocket.FileTransfer.svg?label=RRQMSocket.FileTransfer)](https://www.nuget.org/packages/rrqmsocket.filetransfer)|[Gitee](https://gitee.com/RRQM_Home/rrqmsocket.filetransfer)<br>[Github](https://github.com/RRQM/RRQMSocket.FileTransfer) |  这是一个高性能的C/S架构的文件传输框架，您可以用它传输<br>**任意大小**的文件，它可以完美支持**上传下载混合式队列传输**、<br>**断点续传**、 **快速上传** 、**传输限速**、**获取文件信息**、**删除文件**等。<br>在实际测试中，它的传输速率可达1000Mb/s。 |


## 🖥支持环境
- .NET Framework4.5及以上。
- .NET Core3.1及以上。
- .NET Standard2.0及以上。

 **【Http服务器】** 

HttpService支持**Https协议**、**静态页面**、**WebSocket**、**JsonRpc**、**XmlRpc**、**WebApi**插件的挂载。

```
var service = new HttpService();

service.AddPlugin<MyHttpPlug>();
service.AddPlugin<HttpStaticPagePlugin>().
   AddFolder("../../../../../api");//添加静态页面

service.AddPlugin<WebSocketServerPlugin>().//添加WebSocket功能
   SetWSUrl("").
   SetCallback(WSCallback);

service.AddPlugin<MyWebSocketPlugin>();//添加WS事务触发。

service.AddPlugin<MyWSCommandLinePlugin>();//添加WS命令行事务。

var config = new RRQMConfig();
config.UsePlugin()
    .SetReceiveType(ReceiveType.Auto)
    .SetListenIPHosts(new IPHost[] { new IPHost(7789) });

service.Setup(config).Start();
Console.WriteLine("Http服务器已启动");
Console.WriteLine("浏览器访问：http://127.0.0.1:7789/index.html");
Console.WriteLine("WS访问：ws://127.0.0.1:7789");
```

 **【WebSocket客户端】** 
```csharp
WebSocketClient myWSClient = new WebSocketClient ();
myWSClient.Setup("ws://127.0.0.1:7789");
myWSClient.Connect();
Console.WriteLine("连接成功");

Console.WriteLine("连接成功");
while (true)
{
    myWSClient.SendWithWS(Console.ReadLine());
}
```

## 🧲应用场景模拟
[场景入口](https://gitee.com/RRQM_Home/RRQMBox/wikis/%E5%BA%94%E7%94%A8%E5%9C%BA%E6%99%AF%E6%A8%A1%E6%8B%9F)

***

## 致谢

谢谢大家对我的支持，如果还有其他问题，请加群QQ：234762506讨论。

## 支持作者

[支持入口](https://gitee.com/RRQM_Home/RRQMBox/wikis/%E6%94%AF%E6%8C%81%E4%BD%9C%E8%80%85)
