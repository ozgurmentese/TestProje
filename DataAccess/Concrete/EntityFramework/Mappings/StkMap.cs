using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Concrete.EntityFramework.Mappings
{
    public class StkMap : IEntityTypeConfiguration<Stk>
    {
        public void Configure(EntityTypeBuilder<Stk> builder)
        {
            builder.ToTable(@"STK", "dbo");

            builder.HasKey(s => s.Id);

            builder.Property(s => s.Id).HasColumnName("ID");
            builder.Property(s => s.MalAdi).HasColumnName("MalAdi");
            builder.Property(s => s.MalKodu).HasColumnName("MalKodu");
           
        }
    }

}
