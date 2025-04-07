using System;
using AbstractFactory.Factories;
using AbstractFactory.Devices;
using AbstractFactory;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("Вітаємо в системі створення девайсів!\n");

        DeviceFactory iProneFactory = new IProneFactory();
        DeviceFactory kiaomiFactory = new KiaomiFactory();
        DeviceFactory balaxyFactory = new BalaxyFactory();

        AbstractDevice iProneLaptop = iProneFactory.CreateLaptop();
        AbstractDevice iProneSmartphone = iProneFactory.CreateSmartphone();
        AbstractDevice iProneNetbook = iProneFactory.CreateNetbook();
        AbstractDevice iProneEBook = iProneFactory.CreateEBook();

        AbstractDevice kiaomiLaptop = kiaomiFactory.CreateLaptop();
        AbstractDevice kiaomiSmartphone = kiaomiFactory.CreateSmartphone();
        AbstractDevice kiaomiNetbook = kiaomiFactory.CreateNetbook();
        AbstractDevice kiaomiEBook = kiaomiFactory.CreateEBook();

        AbstractDevice balaxyLaptop = balaxyFactory.CreateLaptop();
        AbstractDevice balaxySmartphone = balaxyFactory.CreateSmartphone();
        AbstractDevice balaxyNetbook = balaxyFactory.CreateNetbook();
        AbstractDevice balaxyEBook = balaxyFactory.CreateEBook();

        Console.WriteLine("Продукти від бренду IProne:");
        iProneLaptop.ShowInfo();
        iProneSmartphone.ShowInfo();
        iProneNetbook.ShowInfo();
        iProneEBook.ShowInfo();

        Console.WriteLine("\nПродукти від бренду Kiaomi:");
        kiaomiLaptop.ShowInfo();
        kiaomiSmartphone.ShowInfo();
        kiaomiNetbook.ShowInfo();
        kiaomiEBook.ShowInfo();

        Console.WriteLine("\nПродукти від бренду Balaxy:");
        balaxyLaptop.ShowInfo();
        balaxySmartphone.ShowInfo();
        balaxyNetbook.ShowInfo();
        balaxyEBook.ShowInfo();

        Console.ReadLine();
    }
}
