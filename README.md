# CoreSignalRSample
ASP.NET Core SignalR sample using WebSocket binary dataframe

blog [http://puni-o.hatenablog.com/entry/2018/07/05/113424]

  
# How to?
  
__Just use MessagePack, that's it!__
  
  
  

## Server

```
Install-Package Microsoft.AspNetCore.SignalR.Protocols.MessagePack
```

```cs:startup.cs
services.AddSignalR()
    .AddMessagePackProtocol();  // Add
```


## Client

```
Install-Package Microsoft.AspNetCore.SignalR.Protocols.MessagePack
```

```cs:startup.cs
var connection = new HubConnectionBuilder()
    .WithUrl("http://localhost:58456/hub/data")
    .AddMessagePackProtocol()  // Add
    .Build();
```
