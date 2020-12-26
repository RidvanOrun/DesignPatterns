using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern.Lab1
{
    public class SystemManger
    {
        private static SystemManger _systemManager; //field tanımladık

        private SystemManger()
        {
            //Amaç dış erişime kapatmak 
        }

        //Bu method bizim asıl singleton nesnesi yaratıcımız rolünde
        public static SystemManger CreateSingletonObject()
        {
            if (_systemManager == null)
            {
                //_systemManager nesnesi null ise yani içi boşsa gel bana SystemManager() nesneyi satar
                _systemManager = new SystemManger();
            }
            //Yok null değilse önceden yaratılmış demektir 
            return _systemManager; //bu yaratılmış nesneyi bana dön
        }

        public void SystemMessage()
        {
            Console.WriteLine("An object was created by Singleton...!");
            Console.ReadKey();
        }
    }
}
