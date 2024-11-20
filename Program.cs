using WeatherApp.Dtos;

var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

List<WeatherDto> weatherInfo = [
    new (
        4994358,
        42.9634m,
        -85.6681m,
        "Clouds",
        "broken clouds",
        280.44m,
        277.39m,
        279.36m,
        281.04m,
        65m,
        1006m,
        4.92m,
        "US",
        TimeOnly.FromDateTime(DateTimeOffset.FromUnixTimeSeconds(1732106522).DateTime),
        TimeOnly.FromDateTime(DateTimeOffset.FromUnixTimeSeconds(1732140910).DateTime),
        "Grand Rapids"
    )
];

app.MapGet("/weather/GR", () => weatherInfo);

app.MapGet("/", () => "Hello World!");

app.Run(); 