using BuilderPattern.Lab2.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Lab2.Directories
{
    class CreditCardDirectory
    {
        public void Constructor(CreditCartBuilder cartBuilder)
        {
            cartBuilder.BankName();
            cartBuilder.CardType();
            cartBuilder.KartLimiti();
            cartBuilder.TaksitleAlma();
        }
    }
}
