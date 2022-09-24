using BlazorSozluk.Api.Domain.Models;
using BlazorSozluk.Infrastructure.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlazorSozluk.Infrastructure.Persistence.EntityConfigurations.Entry
{
    public class EntryFavoriteEntityConfiguration : BaseEntityConfiguration<EntryFavorite>
    {
        public override void Configure(EntityTypeBuilder<EntryFavorite> builder)
        {
            base.Configure(builder);

            builder.ToTable("EntryFavorite", BlazorSozlukContext.DEFAULT_SCHEMA);

            builder.HasOne(x => x.Entry)
                .WithMany(x => x.EntryFavorites)
                .HasForeignKey(x => x.EntryId);

            builder.HasOne(x => x.CreatedBy)
               .WithMany(x => x.EntryFavorites)
               .HasForeignKey(x => x.CreatedById);
        }
    }
}
