using DecoratorPattern.Lab1.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Lab1.Concrete
{
    public class Decorator_B:IBilesen
    {
        IBilesen _bilesen;

        public Decorator_B(IBilesen bilesen) => _bilesen = bilesen;

        public string Operasyon()
        {
            string text = _bilesen.Operasyon();
            text += " bazı IoT süreçleri yönetiyorum";
            return text;
        }

        public string EklenenDavranış()
        {
            return "Ayrıca yüksek lisans yapıyorum.";
        }
    }
}
