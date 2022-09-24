using BlazorSozluk.Api.Domain.Models;
using BlazorSozluk.Infrastructure.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlazorSozluk.Infrastructure.Persistence.EntityConfigurations.EntryComment
{
    public class EntryCommentVoteEntityConfiguration : BaseEntityConfiguration<EntryCommentVote>
    {
        public override void Configure(EntityTypeBuilder<EntryCommentVote> builder)
        {
            base.Configure(builder);

            builder.ToTable("EntryCommentVote", BlazorSozlukContext.DEFAULT_SCHEMA);

            builder.HasOne(x => x.EntryComment)
                .WithMany(x => x.EntryCommentVotes)
                .HasForeignKey(x => x.EntryCommentId);
        }
    }
}
