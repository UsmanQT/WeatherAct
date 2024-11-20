namespace WeatherApp.Dtos;

public record class WeatherDto(
    int Id,
    decimal Lat,
    decimal Long,
    string Main,
    string Description,
    decimal Temperature,
    decimal FeelsLikem,
    decimal MinTemp,
    decimal MaxTemp,
    decimal Humidity,
    decimal Pressure,
    decimal WindSpeed,
    string Country,
    TimeOnly Sunrise,
    TimeOnly Sunset,
    string CityName
);
