using DecoratorPattern.Lab1.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Lab1.Concrete
{
    class Decorator_A:IBilesen
    {
        IBilesen _bilesen;

        public Decorator_A(IBilesen bilesen) => _bilesen = bilesen;

        public string Operasyon()
        {
            string text = _bilesen.Operasyon();
            text += "yazılım tanımlı ağlar ile ";
            return text;
        }
    }
}
