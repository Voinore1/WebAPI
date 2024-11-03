namespace Data.Entities.VenichleInfo
{
    public class Transmission
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Venichle>? Venichles { get; set; }

    }
}
