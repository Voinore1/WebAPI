using Data.Entities.VenichleInfo;

namespace Data.Entities
{
    public class Auction
    {
        public int Id { get; set; }
        public int? VenichleId { get; set; }
        public int SellerId { get; set; }   
        public DateTime TimeStart { get; set; }
        public DateTime TimeEnd { get; set; }
        public string Name { get; set; }
        public string MinDescription { get; set; }
        public int StartPrice { get; set; }
        public int CurrentPrice { get; set; }
        public bool IsSold { get; set; }
        public string CityNow { get; set; }

        public User Seller { get; set; } 
        public Venichle Venichle { get; set; }  
        public ICollection<Comment>? Comments { get; set; }
        public ICollection<Bid>? Bids { get; set; }
    }
}
