using BuilderPattern.Lab1.Delegate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Lab1.Concretes
{
    public class ProductBuilder: BaseProductBuilder
    {
        ProductModel model = new ProductModel();

        public override void ApplyDiscount()
        {
            model.DiscountPrice = model.UnitPrice * (decimal)0.90;
            model.DiscountedAppliyed = true;
        }

        public override ProductModel GetModel() => model;

        public override void GetProductData()
        {
            model.Id = 1;
            model.ProductName = "Çinekop";
            model.UnitPrice = 20;
        }
    }
}
