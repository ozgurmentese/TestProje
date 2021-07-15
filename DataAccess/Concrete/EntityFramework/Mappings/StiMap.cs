using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework.Mappings
{
    public class StiMap : IEntityTypeConfiguration<Sti>
    {
        public void Configure(EntityTypeBuilder<Sti> builder)
        {
            builder.ToTable(@"STI", "dbo");

            builder.HasKey(s => s.Id);

            builder.Property(s => s.Id).HasColumnName("ID");
            builder.Property(s => s.Birim).HasColumnName("Birim");
            builder.Property(s => s.EvrakNo).HasColumnName("EvrakNo");
            builder.Property(s => s.Fiyat).HasColumnName("Fiyat");
            builder.Property(s => s.IslemTur).HasColumnName("IslemTur");
            builder.Property(s => s.MalKodu).HasColumnName("MalKodu");
            builder.Property(s => s.Miktar).HasColumnName("Miktar");
            builder.Property(s => s.Tarih).HasColumnName("Tarih");
            builder.Property(s => s.Tutar).HasColumnName("Tutar");
        }
    }
}
