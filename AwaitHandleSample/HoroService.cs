using Newtonsoft.Json;

namespace AwaitHandleSample;

public class HoroService
{
    public enum ZodiacSign
    {
        Aries,
        Taurus,
        Gemini,
        Cancer,
        Leo,
        Virgo,
        Libra,
        Scorpio,
        Sagittarius,
        Capricorn,
        Aquarius,
        Pisces
    }

    public async Task<AstroForecast?> MakeDailyHoroscopeBySign(ZodiacSign sign)
    {
        var client = new HttpClient();
        var response = await client.GetAsync($"https://ohmanda.com/api/horoscope/{sign.ToString().ToLower()}");
        response.EnsureSuccessStatusCode();
        var json = await response.Content.ReadAsStringAsync();

        var model = JsonConvert.DeserializeObject<AstroForecast>(json);
        model!.Time = DateTime.Now.TimeOfDay;
        
        return model;
    }
}