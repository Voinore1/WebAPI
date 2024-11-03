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
    public class VenichleConfig : IEntityTypeConfiguration<Venichle>
    {
        public void Configure(EntityTypeBuilder<Venichle> builder)
        {
            builder.HasOne(x => x.Auction)
                   .WithOne(x => x.Venichle)
                   .HasForeignKey<Venichle>(x => x.AuctionId);

            builder.HasOne(x => x.Owner)
                   .WithMany(x => x.Venichles)
                   .HasForeignKey(x => x.OwnerId);

            builder.HasOne(x => x.Model)
                   .WithMany(x => x.Venichles)
                   .HasForeignKey(x => x.ModelId)
                   .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(x => x.BodyStyle)
                   .WithMany(x => x.Venichles)
                   .HasForeignKey(x => x.BodyStyleId);

            builder.HasOne(x => x.FuelType)
                   .WithMany(x => x.Venichles)
                   .HasForeignKey(x => x.FuelTypeId);

            builder.HasOne(x => x.Transmission)
                   .WithMany(x => x.Venichles)
                   .HasForeignKey(x => x.TransmissionId);

            builder.HasOne(x => x.Brand)
                   .WithMany(x => x.Venichles)
                   .HasForeignKey(x => x.BrandId);



        }
    }
}
