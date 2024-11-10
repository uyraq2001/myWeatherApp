namespace WeatherApp.Models
{
    public enum City
    {
        Saratow,
        Moscow,
        London
    }

    public class User
    {
        public int Id { get; set; }
        public City HomeTown { get; set; }
        public string Name { get; set; } = "";
    }
}