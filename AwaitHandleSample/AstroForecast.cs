using System.Text.Json.Serialization;

namespace AwaitHandleSample;

public record AstroForecast
{
    [JsonPropertyName("sign")]
    public string? Sign { get; set; }

    [JsonPropertyName("date")]
    public DateTimeOffset Date { get; set; }
    
    [JsonPropertyName("horoscope")]
    public string? Horoscope { get; set; }
    public TimeSpan Time { get; set; }
}