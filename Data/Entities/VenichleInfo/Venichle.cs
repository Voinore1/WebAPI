namespace Data.Entities.VenichleInfo
{
    public class Venichle
    {
        public int Id { get; set; }
        public string VIN { get; set; }
        public int ManufactureDate { get; set; }
        public int Odometr { get; set; }
        public string ExteriorColor { get; set; }
        public string InteriorColor { get; set; } = "Black";
        public bool IsModified { get; set; }
        public bool HaveProblems { get; set; }
        public string? Problems { get; set; }
        public string? Description { get; set; }
        public bool IsHTMLProblemList { get; set; }
        public bool IsHTMLDescription { get; set; }



        public string MainPhotoURL { get; set; } = null!;
        public IList<string>? ExteriorPhotosURLId { get; set; }
        public IList<string>? InteriorPhotosURLId { get; set; }





        public int BrandId { get; set; }
        public int OwnerId { get; set; }    
        public int ModelId { get; set; }
        public int? AuctionId { get; set; }
        public int BodyStyleId { get; set; }
        public int FuelTypeId { get; set; }
        public int TransmissionId { get; set; }



        public BodyStyle BodyStyle { get; set; }
        public FuelType FuelType { get; set; }
        public Transmission Transmission { get; set; }
        public Brand Brand { get; set; }
        public Model Model { get; set; }
        public Auction? Auction { get; set; }
        public User Owner { get; set; } 

    }
}