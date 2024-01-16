# Poc - Bug MySql.Data/MySql.Data.EntityFramework (8.2.0)

## Stack:

- .NET Framework 4.8
- Mvc 5.3.0
- EntityFramework 6.4.4
- MySql.Data 8.2.0
- MySql.Data.EntityFramework 8.2.0

## Description

The app is freezing when multiple requests are made.

The dbContext is not disposed and the request is not finished.

The problem does not occur using MySql.Data 8.1.0.

## How to test

1. Start the database

```bash
docker-compose up
```

2. Run the project in Visual Studio

It will open this page http://localhost:15555/connections.htm

If you keep refreshing it, the app will eventually freeze.


