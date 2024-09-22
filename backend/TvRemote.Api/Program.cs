using TvRemote.Api;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddTransient<IPhilipsTvAccess, PhilipsTvAccess>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapGet("/api/test", () =>
{
    return Results.Ok("Hallo!");
}).WithOpenApi();

app.MapPost("/api/power/off", async (IPhilipsTvAccess tvAccess) =>
{
    bool success = await tvAccess.SendPowerOff();

    return success ? Results.Ok() : Results.StatusCode(StatusCodes.Status502BadGateway);
});

app.MapPost("/api/power/on", async (IPhilipsTvAccess tvAccess) =>
{
    bool success = await tvAccess.SendPowerOn();

    return success ? Results.Ok() : Results.StatusCode(StatusCodes.Status502BadGateway);
});

app.MapPost("/api/home", async (IPhilipsTvAccess tvAccess) =>
{
    bool success = await tvAccess.SendHome();

    return success ? Results.Ok() : Results.StatusCode(StatusCodes.Status502BadGateway);
});

app.MapPost("/api/source", async (IPhilipsTvAccess tvAccess) =>
{
    bool success = await tvAccess.SendSource();

    return success ? Results.Ok() : Results.StatusCode(StatusCodes.Status502BadGateway);
});

app.MapPost("/api/nav/ok", async (IPhilipsTvAccess tvAccess) =>
{
    bool success = await tvAccess.SendOk();

    return success ? Results.Ok() : Results.StatusCode(StatusCodes.Status502BadGateway);
});

app.MapPost("/api/nav/up", async (IPhilipsTvAccess tvAccess) =>
{
    bool success = await tvAccess.SendUp();

    return success ? Results.Ok() : Results.StatusCode(StatusCodes.Status502BadGateway);
});

app.MapPost("/api/nav/down", async (IPhilipsTvAccess tvAccess) =>
{
    bool success = await tvAccess.SendDown();

    return success ? Results.Ok() : Results.StatusCode(StatusCodes.Status502BadGateway);
});

app.MapPost("/api/nav/left", async (IPhilipsTvAccess tvAccess) =>
{
    bool success = await tvAccess.SendLeft();

    return success ? Results.Ok() : Results.StatusCode(StatusCodes.Status502BadGateway);
});

app.MapPost("/api/nav/right", async (IPhilipsTvAccess tvAccess) =>
{
    bool success = await tvAccess.SendRight();

    return success ? Results.Ok() : Results.StatusCode(StatusCodes.Status502BadGateway);
});

app.Run();

