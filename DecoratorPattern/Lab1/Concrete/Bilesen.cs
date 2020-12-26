using DecoratorPattern.Lab1.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Lab1.Concrete
{
    public class Bilesen:IBilesen
    {
        public string Operasyon()
        {
            return "Çalıştığım firma için ";
        }
    }
}
