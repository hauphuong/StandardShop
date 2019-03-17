using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StandardShop.Data.EF.Extensions;
using StandardShop.Data.Entities;

namespace StandardShop.Data.EF.Configurations
{
    public class PageConfiguration : DbEntityConfiguration<Page>
    {
        public override void Configure(EntityTypeBuilder<Page> entity)
        {
            entity.HasKey(c => c.Id);
            entity.Property(c => c.Id).HasMaxLength(255).IsRequired();
        }
    }
}