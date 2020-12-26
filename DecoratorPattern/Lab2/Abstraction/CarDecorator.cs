using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Lab2.Abstraction
{
    public abstract class CarDecorator
    {
        private CarBase _carBase;

        public CarDecorator(CarBase carBase) => _carBase = carBase;

    }
}
