using ObserverPattern.Lab2.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Lab2.Abstract
{
    public class Product
    {
        public string ProductName { get; set; }

        private decimal _price;
        public decimal Price
        {
            get => _price;
            set
            {
                if (_price > value)
                {
                    Notification();
                }
                _price = value;
            }
        }

        public List<ConcreteMember> FollowList = new List<ConcreteMember>();

        private void Notification()
        {
            foreach (IMember member in FollowList)
            {
                member.Update(this);
            }
        }

        public Product(string productName, decimal unitPrice)
        {
            this.ProductName = productName;
            this.Price = unitPrice;
        }
    }
}
