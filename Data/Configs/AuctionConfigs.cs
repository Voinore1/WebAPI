using Data.Entities;
using Data.Entities.VenichleInfo;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Configs
{
    public class AuctionConfigs : IEntityTypeConfiguration<Auction>
    {
        public void Configure(EntityTypeBuilder<Auction> builder)
        {
            builder.HasOne(x => x.Seller).WithMany(x => x.Auctions).HasForeignKey(x => x.SellerId);
        }
    }
}
