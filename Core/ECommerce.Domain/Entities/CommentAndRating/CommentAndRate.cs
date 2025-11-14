using ECommerce.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Domain.Entities.CommentAndRating
{
    public class CommentAndRate: EntityBase
    {
        public Guid CreatedUserId { get; set; }
        public short RatingWithStars { get; set; }//1,2,3,4,5
        public string Comment { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public Guid ProductId { get; set; }
        public Product.Product Product { get; set; }
    }
}
