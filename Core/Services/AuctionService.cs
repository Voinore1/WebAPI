using AutoMapper;
using Core.Exceptions;
using Core.Interfaces;
using Core.Models;
using Data;
using Data.Entities;
using Data.Entities.VenichleInfo;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services
{
    public class AuctionService(IMapper mapper, AuctionDBContext context) : IAuctionService
    {
        public List<AuctionShortModel> GetAllAuctions()
        {
            var auctions = mapper.Map<List<AuctionShortModel>>(context.Auctions.Include(x => x.Seller).Include(x => x.Venichle).ToList());

            return auctions;
        }

        public AuctionFullModel GetAuctionById(int id)
        {
            var auctionEntity = context.Auctions.Include(x => x.Seller).Include(x => x.Venichle).FirstOrDefault(x => x.Id == id);

            if (auctionEntity == null) throw new HttpException($"Auction with id {id} not found", HttpStatusCode.NotFound);

            var auction = mapper.Map<AuctionFullModel>(auctionEntity);

            return auction;
        }

        public void CreateAuction(AuctionCreateModel model)
        {
            var auction = mapper.Map<Auction>(model);

            context.Auctions.Add(auction);
            context.SaveChanges();
        }

        public void EditAuction(AuctionFullModel model)
        {
            var auction = context.Auctions.Include(x => x.Venichle).FirstOrDefault(x => x.Id == model.Id);

            if (auction == null) throw new HttpException($"Auction with id {model.Id} not found", HttpStatusCode.NotFound);

            auction = mapper.Map<Auction>(model);

            context.SaveChanges();
        }

        public void DeleteAuction(int id)
        {
            var auction = context.Auctions.Include(x => x.Venichle).FirstOrDefault(x => x.Id == id);

            if (auction == null) throw new HttpException($"Auction with id {id} not found", HttpStatusCode.NotFound);

            context.Venichles.Remove(auction.Venichle);
            context.Auctions.Remove(auction);
            context.SaveChanges();
        }

        public List<BrandModel> GetAllBrands()
        {
            var brands = mapper.Map<List<BrandModel>>(context.Brands.ToList());

            return brands;
        }

        public List<FuelTypeModel> GetAllFuelTypes()
        {
            var fuelTypes = mapper.Map<List<FuelTypeModel>>(context.FuelTypes.ToList());

            return fuelTypes;
        }

        public List<TransmissionModel> GetAllTransmissions()
        {
            var transmissions = mapper.Map<List<TransmissionModel>>(context.Transmissions.ToList());

            return transmissions;
        }

        public List<BodyStyleModel> GetAllBodyStyles()
        {
            var bodyStyles = mapper.Map<List<BodyStyleModel>>(context.BodyStyles.ToList());

            return bodyStyles;
        }

        public List<CarModelModel> GetAllCarsModel(int id)
        {
            var carModels = mapper.Map<List<CarModelModel>>(context.Models.Where(x => x.BrandId == id).ToList());

            return carModels;
        }
    }
}
