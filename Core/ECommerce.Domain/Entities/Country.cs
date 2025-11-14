using ECommerce.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Domain.Entities
{
    public class Country:EntityBase
    {
        public Country()
        {
            
        }

        public Country(string nAze,string nEng)
        {
            
        }
        public string NameAze { get; set; }
        public string NameEng { get; set; }
        public bool IsActive { get; set; }
    }
}
