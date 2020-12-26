using BuilderPattern.Lab1.Concretes;
using BuilderPattern.Lab1.Directories;
using BuilderPattern.Lab2.Abstraction;
using BuilderPattern.Lab2.Concrete;
using BuilderPattern.Lab2.Directories;
using System;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Lab1
            ProductDirectory productDirectory = new ProductDirectory();
            ProductBuilder baseproductBuilder = new ProductBuilder();

            productDirectory.GenerateProduct(baseproductBuilder);

            var model = baseproductBuilder.GetModel();
            Console.WriteLine(model.Id);
            Console.WriteLine(model.ProductName);
            Console.WriteLine(model.UnitPrice);
            Console.WriteLine(model.DiscountPrice);
            Console.WriteLine(model.DiscountedAppliyed);
            #endregion

            #region Lab2
            CreditCartBuilder gercekKart = new AmerikanExpressCartBuilder();
            CreditCardDirectory kullan = new CreditCardDirectory();
            kullan.Constructor(gercekKart);

            Console.WriteLine(gercekKart.Card.ToString());
            #endregion

            Console.ReadKey();
        }
    }
}
