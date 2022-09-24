using BlazorSozluk.Api.Domain.Models;
using BlazorSozluk.Infrastructure.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlazorSozluk.Infrastructure.Persistence.EntityConfigurations.Entry
{
    public class EntryVoteEntityConfiguration : BaseEntityConfiguration<EntryVote>
    {
        public override void Configure(EntityTypeBuilder<EntryVote> builder)
        {
            base.Configure(builder);

            builder.ToTable("EntryVote", BlazorSozlukContext.DEFAULT_SCHEMA);

            builder.HasOne(x => x.Entry)
                .WithMany(x => x.EntryVotes)
                .HasForeignKey(x => x.EntryId);
        }
    }
}
