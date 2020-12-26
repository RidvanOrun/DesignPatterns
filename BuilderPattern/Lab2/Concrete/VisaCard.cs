using BuilderPattern.Lab2.Abstraction;
using BuilderPattern.Lab2.Delegate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Lab2.Concrete
{
    public class VisaCard: CreditCartBuilder
    {
        public VisaCard()
        {
            card = new CreditCard();
        }

        public override void BankName()
        {
            card.BankName = "Garanti Bankası";
        }

        public override void CardType()
        {
            card.CardType = "Visa Card";
        }

        public override void KartLimiti()
        {
            card.CartLimit = 10000;
        }

        public override void TaksitleAlma()
        {
            card.TaksitleAlma = true;
        }
    }
}
