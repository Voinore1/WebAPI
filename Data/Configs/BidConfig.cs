using Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Configs
{
    public class BidConfig : IEntityTypeConfiguration<Bid>
    {
        public void Configure(EntityTypeBuilder<Bid> builder)
        {
            builder.HasOne(x => x.User)
                   .WithMany(x => x.Bids)
                   .HasForeignKey(x => x.UserId)
                   .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(x => x.Auction)
                   .WithMany(x => x.Bids)
                   .HasForeignKey(x => x.AuctionId);

            builder.Ignore(x => x.Time);
        }
    }
}
