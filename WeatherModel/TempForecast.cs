public class TempForecast
{
    public Coord coord { get; set; } = new Coord();
    public Weather weather { get; set; } = new Weather();
    // public String base { get; set; } = "";
    public MainForecast mainForecast { get; set; } = new MainForecast();
    public int visibility { get; set; }
    public Wind wind { get; set; } = new Wind();
    public Rain rain { get; set; } = new Rain();
    public Snow snow { get; set; } = new Snow();
    public long dt { get; set; }
    public Sys sys { get; set; } = new Sys();
    public int timezone { get; set; }
    public int cod { get; set; }
}

public class Coord
{
    public float lon { get; set; }
    public float lat { get; set; }
}

public class Weather
{
    public int id { get; set; }
    public string main { get; set; } = "";
    public string description { get; set; } = "";
    public string icon { get; set; } = "";
}

public class MainForecast
{
    public float temp { get; set; }
    public float temp_min { get; set; }
    public float temp_max { get; set; }
    public float pressure { get; set; }
    public float humidity { get; set; }
    public float sea_level { get; set; }
    public float grnd_level { get; set; }
}

public class Wind
{
    public float speed { get; set; }
    public float deg { get; set; }
    public float gust { get; set; }
}

public class Rain
{
    public int val { get; set; }
}

public class Snow
{
    public int val { get; set; }
}

public class Sys
{
    public int type { get; set; }
    public int id { get; set; }
    public String country { get; set; } = "";
    public long sunrise { get; set; }
    public long sunset { get; set; }
}