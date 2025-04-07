using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Devices
{
    public class IProneSmartphone : AbstractDevice
    {
        public override string GetDeviceType() => "Смартфон";
        public override string GetBrand() => "IProne";
    }
}
