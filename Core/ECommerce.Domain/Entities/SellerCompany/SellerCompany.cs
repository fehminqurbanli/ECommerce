using ECommerce.Domain.Common;


namespace ECommerce.Domain.Entities.SellerCompany
{
    public class SellerCompany : EntityBase
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string IsActive { get; set; }
        public Guid ProductId { get; set; }
        public Product.Product Product { get; set; }
    }
}
