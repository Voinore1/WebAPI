using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class Bid : IDisplayable
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int AuctionId { get; set; }
        public int Value { get; set; }
        public DateTime BidTime { get; set; }
        public DateTime Time => BidTime;

        public User User { get; set; }
        public Auction Auction { get; set; }
    }
}
