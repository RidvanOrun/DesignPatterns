using SingletonPattern.Lab2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //Not: Lab uyguglamalarında sınıfı, sınıf dışında new anahtar sözcüğü vasıtasıyla üretemeyiz. Bunun nedeni singeleton ile bu nesneleri üreteceğimiz ve zaten bu bağlamda constructor private yaparak dış erişime kapattık ve singleton ters düşmedik

            #region Lab_1
            //var systemManager = SystemManager.CreateSingletonObject();
            //systemManager.SystemMessage();
            #endregion

            #region Lab_2
            int toplam_1 = SingletonClass.Sınıf.Toplam(1, 2);
            Console.WriteLine(toplam_1);
            Console.ReadKey();
            #endregion
        }
    }
}
