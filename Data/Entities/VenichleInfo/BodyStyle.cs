namespace Data.Entities.VenichleInfo
{
    public class BodyStyle
    {
        public int Id { get; set; }
        public string Style { get; set; }
        public ICollection<Venichle>? Venichles { get; set; }


    }
}
