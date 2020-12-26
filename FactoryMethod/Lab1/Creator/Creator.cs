using FactoryMethod.Lab1.Concrete;
using FactoryMethod.Lab1.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Lab1.Creator
{
    public class Creator
    {
        public IProduct FactoryMethod(int month)
        {
            if (month >= 4 && month <= 11)
            {
                return new Product_1();
            }
            else
            {
                if (month == 1 || month == 2 || month == 3)
                {
                    return new Product2();
                }
                else
                {
                    return new DefaultProduct();
                }
            }
        }
    }
}
