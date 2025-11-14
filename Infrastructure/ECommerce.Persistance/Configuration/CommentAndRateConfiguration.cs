using ECommerce.Domain.Entities.CommentAndRating;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ECommerce.Persistance.Configuration
{
    public class CommentAndRateConfiguration : IEntityTypeConfiguration<CommentAndRate>
    {
        public void Configure(EntityTypeBuilder<CommentAndRate> builder)
        {
        }
    }
}
