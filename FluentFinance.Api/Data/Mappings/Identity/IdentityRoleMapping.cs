using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FluentFinance.Api.Data.Mappings.Identity;

public class IdentityRoleMapping : IEntityTypeConfiguration<IdentityRole<long>>
{
  public void Configure(EntityTypeBuilder<IdentityRole<long>> builder)
  {
    builder.ToTable("IdentityRole");

    builder.HasKey(x => x.Id);

    builder.Property(x => x.Id)
      .ValueGeneratedOnAdd()
      .UseIdentityColumn();

    builder.HasIndex(x => x.NormalizedName).IsUnique();

    builder.Property(x => x.ConcurrencyStamp).IsConcurrencyToken();
    
    builder.Property(x => x.Name)
      .HasMaxLength(256)
      .IsRequired();
    
    builder.Property(x => x.NormalizedName)
      .HasMaxLength(256)
      .IsRequired();
  }
}