using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SalesManagementSystem.DATA.Entites;

namespace SalesManagementSystem.DATA.Configurations;

public class PersonTypeConfiguration : IEntityTypeConfiguration<PersonType> 
{
    public void Configure(EntityTypeBuilder<PersonType> builder)
    {
        builder.ToTable("PersonTypes");
        
    }
}