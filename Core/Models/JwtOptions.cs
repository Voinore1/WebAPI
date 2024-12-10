namespace Core.Models
{
    public class JwtOptions
    {
        public string Key { get; set; }
        public int LifeTimeInMinutes { get; set; }
        public string Issuer { get; set; }
    }

}
