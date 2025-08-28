# SignalR Scale-Out with Redis (Redis-Backplane)

This is a minimal ASP.NET Core project demonstrating how to scale out a SignalR Hub across multiple server instances using a Redis backplane.

---

## Setup

1.  **Install the NuGet Package:** You need to add the required package to your project.
    * [**Microsoft.AspNetCore.SignalR.StackExchangeRedis**](your_link_here)

2.  **Configure Connection String:** Add your Redis connection string to the `appsettings.json` file.

    ```json
    {
      "ConnectionStrings": {
        "Redis": "your_redis_connection_string_here"
      }
    }
    ```

---

## How to Run

1.  Clone the repository.
2.  Ensure your Redis server is running.
3.  Run the application using the .NET CLI:
    ```bash
    dotnet run
    ```
4.  You can run multiple instances of the application to test the scale-out functionality.

---

## References

* [Microsoft Docs: ASP.NET Core SignalR Scale-Out with Redis](https://learn.microsoft.com/en-us/aspnet/signalr/overview/performance/scaleout-with-redis)

* [Microsoft Docs: ASP.NET Core SignalR hosting and scaling](https://learn.microsoft.com/en-us/aspnet/core/signalr/scale?view=aspnetcore-9.0)

* [Microsoft Docs: Set up a Redis backplane for ASP.NET Core SignalR scale-out](https://learn.microsoft.com/en-us/aspnet/core/signalr/redis-backplane?view=aspnetcore-9.0)

