using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Devices
{
    public class BalaxyLaptop : AbstractDevice
    {
        public override string GetDeviceType() => "Ноутбук";
        public override string GetBrand() => "Balaxy";
    }
}
