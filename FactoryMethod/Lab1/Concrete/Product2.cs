using FactoryMethod.Lab1.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Lab1.Concrete
{
    class Product2 : IProduct
    {
        public string ShipFrom() => "from Columbia";
   
    }
}
