using System;
using FactoryMethod.Lab1.Creator;
using FactoryMethod.Lab1.Concrete;
using FactoryMethod.Lab1.Interface;
using FactoryMethod.Lab2.Concrete;
using FactoryMethod.Lab2.Creator;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Lab_1
            Creator c = new Creator();

            IProduct product;

            for (int month = 1; month <= 12; month++)
            {
                product = c.FactoryMethod(month);
                Console.WriteLine("Coffee Beans " + product.ShipFrom());
            }
            #endregion


            #region Lab_2
            SystemManager systemManager = new SystemManager(new SystemLoggerFactory());
            systemManager.Save();

            #endregion
            Console.ReadKey();
        }
    }
}
