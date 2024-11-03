using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class Comment : IDisplayable
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int AuctionId { get; set; }
        public string Text { get; set; }
        public bool IsSeller { get; set; }
        public DateTime CommentTime { get; set; }
        public DateTime Time => CommentTime;

        public User User { get; set; }
        public Auction Auction { get; set; }
    }
}
