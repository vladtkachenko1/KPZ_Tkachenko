using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Devices; 


namespace AbstractFactory.Factories
{
    public class BalaxyFactory : DeviceFactory
    {
        public override AbstractDevice CreateLaptop() => new BalaxyLaptop();
        public override AbstractDevice CreateNetbook() => new BalaxyNetbook();
        public override AbstractDevice CreateEBook() => new BalaxyEBook();
        public override AbstractDevice CreateSmartphone() => new BalaxySmartphone();
    }
}
