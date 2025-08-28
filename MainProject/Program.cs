using StackExchange.Redis;

var builder = WebApplication.CreateBuilder(args);

var redisSettings = builder.Configuration.GetSection("RedisSettings");

var redisConnectionString = redisSettings.GetValue<string>("ConnectionString");

if(redisConnectionString == null) throw new Exception("Redis connection string not found");

builder.Services.AddSignalR()
    .AddStackExchangeRedis(redisConnectionString, options =>
    {
        options.Configuration.ChannelPrefix = RedisChannel.Literal("channel:signalr:");
    });

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();