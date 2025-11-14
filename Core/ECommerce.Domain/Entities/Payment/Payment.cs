using ECommerce.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Domain.Entities.Payment
{
    public class Payment: EntityBase
    {
        public bool IsViaBankCard { get; set; }
        public bool IsCredit { get; set; }
        public bool IsBirbankInstallmentPlan { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public Guid ProductId { get; set; }
        public Product.Product Product { get; set; }
    }
}
