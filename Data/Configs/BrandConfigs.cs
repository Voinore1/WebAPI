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
    public class BrandConfigs : IEntityTypeConfiguration<Brand>
    {
        public void Configure(EntityTypeBuilder<Brand> builder)
        {
            builder.HasMany(x => x.Models).WithOne(x => x.Brand).HasForeignKey(x => x.BrandId);
        }

    }
}
