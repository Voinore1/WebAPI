using Data.Entities.VenichleInfo;
using Microsoft.AspNetCore.Identity;

namespace Data.Entities
{
    public class User : IdentityUser<int>
    {
        public ICollection<Bid>? Bids { get; set; }
        public ICollection<Comment>? Comments { get; set; }
        public ICollection<Auction>? Auctions { get; set; }
        public ICollection<Venichle>? Venichles { get; set; }

    }
}
