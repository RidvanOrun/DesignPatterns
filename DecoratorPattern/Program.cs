using DecoratorPattern.Lab1.Clients;
using DecoratorPattern.Lab1.Concrete;
using DecoratorPattern.Lab1.Interface;
using DecoratorPattern.Lab2.Client;
using DecoratorPattern.Lab2.Concrete;
using System;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Lab_1
            IBilesen bilesen = new Bilesen();

            Client.Display("1.Basit Bileşen: ", bilesen);
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            Client.Display("2.Bileşen A-Dekaratörü Eklendi: ", new Decorator_A(bilesen));
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            Client.Display("3.Bilesen B-Dekaratörü Eklendi: ", new Decorator_B(bilesen));
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            Client.Display("4.Bilesen İlk Önce A-Dekaratörü sonra B-Dekaratörü Eklendi: ", new Decorator_B(new Decorator_A(bilesen)));
            Console.WriteLine("\n");
            Console.WriteLine("\n");



            Decorator_B decorator_B = new Decorator_B(new Bilesen());
            Client.Display("5.Bilesen İlk Önce B-Dekaratörü sonra B-Dekaratörü Eklendi: ", new Decorator_B(decorator_B));


            Console.WriteLine("\t\t\t" + decorator_B.EklenenDavranış());
            #endregion


            #region Lab_1
            var mycar = new SUV { Marka = "Dodge", Model = "2019 Ram Power Wagon", HirePrice = 55000 };

            HireOffer hireOffer = new HireOffer(mycar);
            hireOffer.DiscountPersantage = 10;

            Console.WriteLine("First Hire Price: {0}", mycar.HirePrice);
            Console.WriteLine("Discount Applied Price: {0}", hireOffer.HirePrice);
            #endregion
            Console.ReadKey();
        }
    }
}
