using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StandardShop.Data.EF.Extensions;
using StandardShop.Data.Entities;

namespace StandardShop.Data.EF.Configurations
{
    public class AdvertistmentPositionConfiguration : DbEntityConfiguration<AdvertistmentPosition>
    {
        public override void Configure(EntityTypeBuilder<AdvertistmentPosition> entity)
        {
            entity.Property(c => c.Id).HasMaxLength(20).IsRequired();
        }
    }
}