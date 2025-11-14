using ECommerce.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Domain.Entities.Delivery
{
    public class Delivery: EntityBase
    {
        public bool IsCourier { get; set; }
        public bool IsTakingFromAcceptingPlace { get; set; }
        public bool IsExpressShipping { get; set; }
        public bool IsShippingForAzerPoct { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public Guid ProductId { get; set; }
        public Product.Product Product { get; set; }
    }
}
