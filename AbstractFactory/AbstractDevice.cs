using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public abstract class AbstractDevice
    {
        public abstract string GetDeviceType();
        public abstract string GetBrand();

        public virtual void ShowInfo()
        {
            Console.WriteLine($"Тип пристрою: {GetDeviceType()} | Бренд: {GetBrand()}");
        }
    }
}
