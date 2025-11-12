using ECommerce.Domain.Common;

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
        public Guid DeliveryId { get; set; } //Çatdırılma üçün cədvəl yaradılacaq
        public Guid PaymentId { get; set; } //Çatdırılma üçün cədvəl yaradılacaq
        public Guid CommentId { get; set; } //Şərhlər və qiymətləndirmə
        public Guid ProductDetailId { get; set; } //Məhsul haqqında Detallı məlumat

    }
}
