using BuilderPattern.Lab2.Delegate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Lab2.Abstraction
{
    public abstract class CreditCartBuilder
    {
        protected CreditCard card;

        public CreditCard Card { get => card; }

        public abstract void BankName();
        public abstract void CardType();
        public abstract void KartLimiti();
        public abstract void TaksitleAlma();
    }
}
