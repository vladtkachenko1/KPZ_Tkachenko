using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Devices
{
    public class KiaomiEBook : AbstractDevice
    {
        public override string GetDeviceType() => "Електронна книга";
        public override string GetBrand() => "Kiaomi";
    }
}
