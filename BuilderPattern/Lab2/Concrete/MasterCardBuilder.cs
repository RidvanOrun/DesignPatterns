using BuilderPattern.Lab2.Abstraction;
using BuilderPattern.Lab2.Delegate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Lab2.Concrete
{
    public class MasterCardBuilder: CreditCartBuilder
    {
        public MasterCardBuilder()
        {
            card = new CreditCard();
        }

        public override void BankName()
        {
            card.BankName = "Türkiye İş Bankası";
        }

        public override void CardType()
        {
            card.CardType = "Master Card";
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
