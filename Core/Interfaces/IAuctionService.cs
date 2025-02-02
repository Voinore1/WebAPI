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
        List<BrandModel> GetAllBrands();
        List<FuelTypeModel> GetAllFuelTypes();
        List<TransmissionModel> GetAllTransmissions();
        List<BodyStyleModel> GetAllBodyStyles();
        List<CarModelModel> GetAllCarsModel(int id);



        void CreateAuction(AuctionCreateModel model);
        void EditAuction(AuctionFullModel model);
        void DeleteAuction(int id);

    }
}
