namespace Core.Models
{
    public class AuctionFullModel 
    {
        public int Id { get; set; }
        public int SellerId { get; set; }
        public DateTime TimeStart { get; set; }
        public DateTime TimeEnd { get; set; }
        public string Name { get; set; }
        public string MinDescription { get; set; }
        public int StartPrice { get; set; }
        public string CityNow { get; set; }

        // Vehicle properties
        public string VIN { get; set; }
        public int ManufactureDate { get; set; }
        public int Odometr { get; set; }
        public string ExteriorColor { get; set; }
        public string? Problems { get; set; }
        public string? Description { get; set; }
        public bool IsModified { get; set; }
        public bool HaveProblems { get; set; }
        public bool IsHTMLProblemList { get; set; }
        public bool IsHTMLDescription { get; set; }
        public string MainPhoto { get; set; } = null!;
        public IList<string>? ExteriorPhotos { get; set; }
        public IList<string>? InteriorPhotos { get; set; }
        public int BrandId { get; set; }
        public int OwnerId { get; set; }
        public int ModelId { get; set; }
        public int BodyStyleId { get; set; }
        public int FuelTypeId { get; set; }
        public int TransmissionId { get; set; }
    }
}
