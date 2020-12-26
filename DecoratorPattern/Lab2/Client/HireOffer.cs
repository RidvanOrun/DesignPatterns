using DecoratorPattern.Lab2.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Lab2.Client
{
    public class HireOffer:CarDecorator
    {
        private readonly CarBase _carBase;

        public HireOffer(CarBase carBase) : base(carBase) => _carBase = carBase;

        public override string Marka { get; set; }
        public override string Model { get; set; }

        public override decimal HirePrice { get => _carBase.HirePrice - _carBase.HirePrice * DiscountPersantage / 100; set { } }

        public int DiscountPersantage { get; set; }
    }
}
