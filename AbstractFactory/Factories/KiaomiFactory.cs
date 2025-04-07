using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factories
{
    public class KiaomiFactory : DeviceFactory
    {
        public override AbstractDevice CreateLaptop() => new KiaomiLaptop();
        public override AbstractDevice CreateNetbook() => new KiaomiNetbook();
        public override AbstractDevice CreateEBook() => new KiaomiEBook();
        public override AbstractDevice CreateSmartphone() => new KiaomiSmartphone();
    }
}

