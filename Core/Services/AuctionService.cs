using AutoMapper;
using Core.Interfaces;
using Core.Models;
using Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
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

            if (auctionEntity == null) throw new Exception($"Auction with id {id} not found");

            var auction = mapper.Map<AuctionFullModel>(auctionEntity);

            return auction;
        }
    }
}
