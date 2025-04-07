using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class IProneNetbook : AbstractDevice
    {
        public override string GetDeviceType() => "Нетбук";
        public override string GetBrand() => "IProne";
    }
