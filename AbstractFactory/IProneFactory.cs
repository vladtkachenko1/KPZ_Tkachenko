using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class IProneFactory : DeviceFactory
    {
        public override AbstractDevice CreateLaptop() => new IProneLaptop();
        public override AbstractDevice CreateNetbook() => new IProneNetbook();
        public override AbstractDevice CreateEBook() => new IProneEBook();
        public override AbstractDevice CreateSmartphone() => new IProneSmartphone();
    }
}
