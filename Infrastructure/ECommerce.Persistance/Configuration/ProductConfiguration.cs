using ECommerce.Domain.Entities.CommentAndRating;
using ECommerce.Domain.Entities.Delivery;
using ECommerce.Domain.Entities.Payment;
using ECommerce.Domain.Entities.Product;
using ECommerce.Domain.Entities.SellerCompany;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ECommerce.Persistance.Configuration
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            // Product silindikdə aşağıdakılar da silinir
            builder.HasOne(p => p.CommentAndRate)
                .WithOne(c => c.Product)
                .HasForeignKey<CommentAndRate>(c => c.ProductId)
                .OnDelete(DeleteBehavior.Cascade);
            
            builder.HasOne(p => p.SellerCompany)
                .WithOne(c => c.Product)
                .HasForeignKey<SellerCompany>(c => c.ProductId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(p => p.Delivery)
                .WithOne(c => c.Product)
                .HasForeignKey<Delivery>(c => c.ProductId)
                .OnDelete(DeleteBehavior.Cascade);
            
            builder.HasOne(p => p.Payment)
                .WithOne(c => c.Product)
                .HasForeignKey<Payment>(c => c.ProductId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
