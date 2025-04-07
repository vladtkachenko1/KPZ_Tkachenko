using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
        public abstract class DeviceFactory
        {
            public abstract AbstractDevice CreateLaptop();
            public abstract AbstractDevice CreateNetbook();
            public abstract AbstractDevice CreateEBook();
            public abstract AbstractDevice CreateSmartphone();
        }
}
