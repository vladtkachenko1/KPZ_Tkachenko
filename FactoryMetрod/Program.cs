using System;
using FactoryMethod;
using FactoryMetрod;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("Вітаємо у системі оформлення відеопідписок!\n");

        // Створення джерел оформлення підписок
        ISubscriptionCreator вебСайт = new WebsiteCreator();
        ISubscriptionCreator мобільнийДодаток = new MobileAppCreator();
        ISubscriptionCreator дзвінокМенеджера = new ManagerCallCreator();

        Console.WriteLine("Починаємо оформлення підписок...\n");

        // Вебсайт — Domestic
        Console.WriteLine("Оформлення підписки через вебсайт (тип: 'domestic'):");
        Subscription підписка1 = вебСайт.CreateSubscription("domestic");
        Console.WriteLine("Підписку успішно створено.\n");

        // Мобільний додаток — Educational
        Console.WriteLine("Оформлення підписки через мобільний додаток (тип: 'educational'):");
        Subscription підписка2 = мобільнийДодаток.CreateSubscription("educational");
        Console.WriteLine("Підписку успішно створено.\n");

        // Менеджер — Premium
        Console.WriteLine("Оформлення підписки через дзвінок менеджера (тип: 'premium'):");
        Subscription підписка3 = дзвінокМенеджера.CreateSubscription("premium");
        Console.WriteLine("Підписку успішно створено.\n");

        // Вивід інформації
        Console.WriteLine("Результати оформлення підписок:\n");

        Console.WriteLine("1. Підписка через вебсайт:");
        підписка1.ShowInfo();

        Console.WriteLine("2. Підписка через мобільний додаток:");
        підписка2.ShowInfo();

        Console.WriteLine("3. Підписка через дзвінок менеджера:");
        підписка3.ShowInfo();

        Console.WriteLine("Усі підписки було створено успішно. Натисніть Enter для завершення...");
        Console.ReadLine();
    }
}
