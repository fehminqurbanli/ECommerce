using ECommerce.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Domain.Entities.Product.Phones_SmartDevices_Accessories
{
    public class MobilePhone_And_SmartPhone: EntityBase
    {
        public bool IsActive { get; set; }
        public string DeviceType { get; set; }
        public string Model { get; set; }
        public string OperatingSystem { get; set; }
        public short CountOfSimCard { get; set; }
        public string SimCardType { get; set; }
        public double ScreenSizw { get; set; }
    }
}
