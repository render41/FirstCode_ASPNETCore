// Configure Builder
var builder = WebApplication.CreateBuilder(args);

// Configure App
var app = builder.Build();

// Behaviors App
app.MapGet("/", () => "Hello World!");
app.MapGet("/testes", () => "Test App");

app.Run();
