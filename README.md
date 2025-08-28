# SignalR Scale-Out with Redis (Redis-Backplane)

A guide on how to scale out an ASP.NET Core SignalR Hub across multiple server instances using a Redis backplane.

---

## Configuration Steps

To enable SignalR scale-out with Redis in your own project, follow these steps.

### 1. Install the NuGet Package

First, add the required package to your project using the .NET CLI:

```bash
dotnet add package Microsoft.AspNetCore.SignalR.StackExchangeRedis
````

### 2\. Configure Connection String

Next, add your Redis connection string to your `appsettings.json` file.

```json
{
  "ConnectionStrings": {
    "Redis": "your_redis_connection_string_here"
  }
}
```

### 3\. Add the Service Configuration

Finally, configure the Redis backplane in your `Program.cs` file. This code reads the connection string and tells SignalR to use Redis for message distribution.

```csharp
var builder = WebApplication.CreateBuilder(args);

// Get the Redis connection string
var connectionString = builder.Configuration.GetConnectionString("Redis");

if (string.IsNullOrEmpty(connectionString))
{
    throw new InvalidOperationException("The Redis connection string was not found.");
}

// Add SignalR and the Redis backplane
builder.Services.AddSignalR()
    .AddStackExchangeRedis(connectionString, options => {
        options.Configuration.ChannelPrefix = "YourAppName:";
    });

// ... rest of your Program.cs
```

-----

## References

* [Microsoft Docs: ASP.NET Core SignalR Scale-Out with Redis](https://learn.microsoft.com/en-us/aspnet/signalr/overview/performance/scaleout-with-redis)

* [Microsoft Docs: ASP.NET Core SignalR hosting and scaling](https://learn.microsoft.com/en-us/aspnet/core/signalr/scale?view=aspnetcore-9.0)

* [Microsoft Docs: Set up a Redis backplane for ASP.NET Core SignalR scale-out](https://learn.microsoft.com/en-us/aspnet/core/signalr/redis-backplane?view=aspnetcore-9.0)

