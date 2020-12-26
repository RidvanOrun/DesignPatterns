using ObserverPattern.Lab1.Concrete;
using ObserverPattern.Lab1.EventManger;
using ObserverPattern.Lab2.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Lab_1
            var customerObserver = new CustomerObserver();

            ProductManager productManager = new ProductManager();
            productManager.Attached(new EmployeeObserver());
            productManager.Attached(customerObserver);
            productManager.UpdatePrice();
            #endregion


            #region Lab_2
            ConcreteProduct concreteProduct = new ConcreteProduct("Boxing Gloves", 12.55M);

            concreteProduct.FollowList.Add(new ConcreteMember { Email = "burakyilmaz@gmail.com" });
            concreteProduct.FollowList.Add(new ConcreteMember { Email = "ipekyilmaz@gmail.com" });
            concreteProduct.FollowList.Add(new ConcreteMember { Email = "hakanyilmaz@gmail.com" });

            concreteProduct.Price = 8.99M;

            #endregion

            Console.ReadKey();
        }
    }
}
