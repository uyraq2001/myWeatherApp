public class ForecastAnswer
{
    public double lat { get; set; }
    public double lon { get; set; }
    public String timezone { get; set; }
    public long timezone_offset { get; set; }
    public Forecast current { get; set; }
}
public class Forecast
{
    public long dt { get; set; }
    public long sunrise { get; set; }
    public long sunset { get; set; }
    public double temp { get; set; }
    public double feels_like { get; set; }
    public int presure { get; set; }
    public int humidity { get; set; }
    public double dew_point { get; set; }
    public double uvi { get; set; }
    public int clouds { get; set; }
    public int visibility { get; set; }
    public double wind_speed { get; set; }
    public int wind_deg { get; set; }
    public double wind_gust { get; set; }
    public double pop { get; set; }
    public GeneralWeather weather { get; set; }
}

public class GeneralWeather
{
    public long id { get; set; }
    public String main { get; set; }
    public String description { get; set; }
    public String icon { get; set; }
}