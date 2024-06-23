var builder = WebApplication.CreateBuilder(args);

// IOC services
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Pipeline
var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseHttpsRedirection();

app.MapGet("/text-message", (HttpContext httpContext) =>
    {
        // code here
    })
    .WithName("TestMessage")
    .WithOpenApi()
    .RequireAuthorization();

app.Run();