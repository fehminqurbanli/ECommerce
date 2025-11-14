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
        public double ScreenSize { get; set; }
        public short Memory { get; set; }
        public string MemorySizeType { get; set; }//gb or tb
        public short Ram { get; set; }
        public short MainCameraPixel { get; set; }
        public short BatteryCapacity { get; set; }
        public short WeightWithGram { get; set; }
        public Guid CountryId { get; set; }
        public Country Country { get; set; }
        public Guid ProductId { get; set; }
        public Product Product { get; set; }
    }
}
