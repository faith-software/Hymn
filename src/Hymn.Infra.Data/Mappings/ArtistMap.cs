using Hymn.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Hymn.Infra.Data.Mappings
{
    public class ArtistMap : IEntityTypeConfiguration<Artist>
    {
        public void Configure(EntityTypeBuilder<Artist> builder)
        {
            builder.Property(e => e.Id)
                .HasColumnName("Id");

            builder.Property(e => e.Name)
                .HasColumnType("varchar(100)")
                .HasMaxLength(100)
                .IsRequired();

            builder.HasKey(e => e.Id);

            builder.HasMany(e => e.Albums)
                .WithOne(e => e.Artist);
        }
    }
}