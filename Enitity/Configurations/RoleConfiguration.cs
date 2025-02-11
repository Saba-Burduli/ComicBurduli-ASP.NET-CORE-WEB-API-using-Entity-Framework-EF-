using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SalesManagementSystem.DATA.Entites;

namespace SalesManagementSystem.DATA.Configurations;

public class RoleConfiguration : IEntityTypeConfiguration<Role> 
{
    public void Configure(EntityTypeBuilder<Role> builder)
    {
        builder.ToTable("Roles");   
    }
}