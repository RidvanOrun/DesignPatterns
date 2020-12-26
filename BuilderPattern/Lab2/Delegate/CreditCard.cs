using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Lab2.Delegate
{
    public class CreditCard
    {
        public string BankName { get; set; }
        public string CardType { get; set; }
        public int CartLimit { get; set; }
        public bool TaksitleAlma { get; set; }

        public override string ToString()
        {
            return $"{BankName} bankasına ait müşteri {CardType}'nı kullanmakta ve kartının {CartLimit} limitine sahiptir. Ayrıca taksit alma seçeneği ise: {TaksitleAlma}";
        }
    }
}
