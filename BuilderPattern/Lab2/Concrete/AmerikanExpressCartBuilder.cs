using BuilderPattern.Lab2.Abstraction;
using BuilderPattern.Lab2.Delegate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Lab2.Concrete
{
    class AmerikanExpressCartBuilder:CreditCartBuilder
    {
        public AmerikanExpressCartBuilder()
        {
            card = new CreditCard();
        }

        public override void BankName()
        {
            card.BankName = "Bank of America";
        }

        public override void CardType()
        {
            card.CardType = "American Express";
        }

        public override void KartLimiti()
        {
            card.CartLimit = 100000;
        }

        public override void TaksitleAlma()
        {
            card.TaksitleAlma = false;
        }
    }
}
