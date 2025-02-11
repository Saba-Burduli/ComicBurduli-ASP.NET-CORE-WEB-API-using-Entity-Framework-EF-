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
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
           builder.ToTable("Orders");

            //builder.HasOne<PaymentType>()
            //    .WithMany()
            //    .HasForeignKey(o => o.PaymentId)
            //    .OnDelete(DeleteBehavior.NoAction);

            //builder.HasOne<Person>()
            //    .WithMany()
            //    .HasForeignKey(p=>p.PersonId)
            //    .OnDelete(DeleteBehavior.Restrict);

            //builder.HasOne<OrderStatus>()
            //    .WithMany()
            //    .HasForeignKey(os=>os.OrderStatusId)
            //    .OnDelete(DeleteBehavior.NoAction); 
                
        }
    }
}
