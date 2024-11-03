using Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Configs
{
    public class CommentConfig : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.HasOne(x => x.User)
                   .WithMany(x => x.Comments)
                   .HasForeignKey(x => x.UserId)
                   .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(x => x.Auction)
                   .WithMany(x => x.Comments)
                   .HasForeignKey(x => x.AuctionId);

            builder.Ignore(x => x.Time);
        }
    }
}
