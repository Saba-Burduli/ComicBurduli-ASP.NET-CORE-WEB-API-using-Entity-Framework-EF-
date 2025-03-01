using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SalesManagementSystem.DATA.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagementSystem.DATA.Configurations
{
    public class UserConfiguration :IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {

            builder.HasMany(U => U.Roles)
                .WithMany(R => R.Users)
                .UsingEntity<Dictionary<string, object>>(
                "RoleUser", // join table name
            left => left.HasOne<Role>()
                .WithMany()
                .HasForeignKey("RoleId")
                .OnDelete(DeleteBehavior.Cascade),

            right => right.HasOne<User>()
                .WithMany()
                .HasForeignKey("UserId")
                .OnDelete(DeleteBehavior.Cascade));
            

        }

    }
}
