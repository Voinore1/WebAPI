﻿using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IAuctionService
    {
        List<AuctionShortModel> GetAllAuctions();
        AuctionFullModel GetAuctionById(int id);
        void CreateAuction(AuctionCreateModel model);
        void EditAuction(AuctionFullModel model);
        void DeleteAuction(int id);
    }
}
