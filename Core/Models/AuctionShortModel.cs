using Data.Entities.VenichleInfo;
using Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Core.Models
{
    public class AuctionShortModel
    {
        public int Id { get; set; }
        public int SellerId { get; set; }
        public int VenichleId { get; set; }
        public DateTime TimeStart { get; set; }
        public DateTime TimeEnd { get; set; }
        public string Name { get; set; }
        public string MinDescription { get; set; }
        public int StartPrice { get; set; }
        public int CurrentPrice { get; set; }
        public bool IsSold { get; set; }
        public string CityNow { get; set; }
        public string MainPhotoURL { get; set; }


        public string SellerUserName { get; set; }
    }
    
}
