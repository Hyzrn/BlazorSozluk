using BlazorSozluk.Api.Domain.Models;
using BlazorSozluk.Infrastructure.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlazorSozluk.Infrastructure.Persistence.EntityConfigurations.EntryComment
{
    public class EntryCommentFavoriteEntityConfiguration : BaseEntityConfiguration<EntryCommentFavorite>
    {
        public override void Configure(EntityTypeBuilder<EntryCommentFavorite> builder)
        {
            base.Configure(builder);

            builder.ToTable("EntryCommentFavorite", BlazorSozlukContext.DEFAULT_SCHEMA);

            builder.HasOne(x => x.EntryComment)
                .WithMany(x => x.EntryCommentFavorites)
                .HasForeignKey(x => x.EntryCommentId);

            builder.HasOne(x => x.CreatedBy)
                .WithMany(x => x.EntryCommentFavorites)
                .HasForeignKey(x => x.CreatedById);
        }
    }
}
