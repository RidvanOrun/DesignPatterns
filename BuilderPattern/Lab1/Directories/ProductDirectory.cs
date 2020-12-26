
using BuilderPattern.Lab1.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Lab1.Directories
{
    public class ProductDirectory
    {
        public void GenerateProduct(BaseProductBuilder productBuilder)
        {
            productBuilder.GetProductData();
            productBuilder.GetModel();
            productBuilder.ApplyDiscount();
        }
    }
}
