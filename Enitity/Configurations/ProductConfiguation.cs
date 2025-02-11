using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SalesManagementSystem.DATA.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagementSystem.DATA.Configurations
{
    public class ProductConfiguation : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Products");

            //builder.HasOne<Category>()
            //    .WithMany()
            //    .HasForeignKey(p => p.ProductId)
            //    .OnDelete(DeleteBehavior.NoAction);

            //builder.HasOne<Rating>()
            //    .WithMany()
            //    .HasForeignKey(p => p.RatingId)
            //    .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
