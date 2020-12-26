using DecoratorPattern.Lab2.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Lab2.Concrete
{
    public class SUV:CarBase
    {
        public override string Marka { get; set; }
        public override string Model { get; set; }
        public override decimal HirePrice { get; set; }
    }
}
