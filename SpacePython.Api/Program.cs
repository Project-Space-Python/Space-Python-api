var builder = WebApplication.CreateBuilder(args);

// ✅ Register MVC controllers
builder.Services.AddControllers();

// ✅ Register OpenAPI docs via minimal API style
builder.Services.AddOpenApi();

var app = builder.Build();

// ✅ Enable OpenAPI routing if in development
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi(); // You are using AddOpenApi, so this is correct
}

// Optional: Redirect HTTP to HTTPS (disabled for now)
// app.UseHttpsRedirection();

app.UseAuthorization();

// ✅ Enable controller route mapping
app.MapControllers();

// ✅ Minimal API test route (your original code)
var summaries = new[]
{
    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
};

app.MapGet("/weatherforecast", () =>
{
    var forecast = Enumerable.Range(1, 5).Select(index =>
        new WeatherForecast
        (
            DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            Random.Shared.Next(-20, 55),
            summaries[Random.Shared.Next(summaries.Length)]
        ))
        .ToArray();
    return forecast;
})
.WithName("GetWeatherForecast");

app.Run();

record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}
