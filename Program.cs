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
    ),
    new (
        5391959,
        37.7669m,
        -122.4321m,
        "Clouds",
        "overcast clouds",
        288.1m,
        287.61m,
        286.25m,
        289.71m,
        75m,
        1016m,
        8.49m,
        "US",
        TimeOnly.FromDateTime(DateTimeOffset.FromUnixTimeSeconds(1732114563).DateTime),
        TimeOnly.FromDateTime(DateTimeOffset.FromUnixTimeSeconds(1732150519).DateTime),
        "San Francisco"
)
];

app.MapGet("/weather", () => weatherInfo);

app.MapGet("/weather/{lat}/{lng}", (decimal lat, decimal lng) => {
    WeatherDto? weatherData = weatherInfo.Find(weatherInfo => weatherInfo.Lat == lat && weatherInfo.Long == lng);

    return weatherData is null ? Results.NotFound() : Results.Ok(weatherData);
});

app.Run(); 