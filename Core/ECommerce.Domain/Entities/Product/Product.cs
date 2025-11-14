using ECommerce.Domain.Common;
using ECommerce.Domain.Entities.Delivery;

namespace ECommerce.Domain.Entities.Product
{
    public class Product: EntityBase
    {
        public string Name { get; set; }
        public string ProductCode { get; set; }
        public string? Description { get; set; }
        public bool IsActive { get; set; }
        public double MainPrice { get; set; }
        public double DiscountedPrice { get; set; }
        public double Discount { get; set; }
        public SellerCompany.SellerCompany SellerCompany { get; set; } //satan şirkət üçün cədvəl yaradılacaq
        public Delivery.Delivery Delivery { get; set; } //Çatdırılma üçün cədvəl yaradılacaq
        public Payment.Payment Payment { get; set; } //Çatdırılma üçün cədvəl yaradılacaq
        public CommentAndRating.CommentAndRate CommentAndRate { get; set; } //Şərhlər və qiymətləndirmə
     

    }
}
