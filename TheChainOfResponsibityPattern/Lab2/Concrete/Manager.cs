using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheChainOfResponsibityPattern.Lab2.Abstract;
using TheChainOfResponsibityPattern.Lab2.Model;

namespace TheChainOfResponsibityPattern.Lab2.Concrete
{
    public class Manager:BaseHandler
    {
        public override void HandleExpense(Expense expense)
        {
            if (expense.Amount <= 1000)
            {
                Console.WriteLine("Manager handle the expense..!");
            }
            else if (_next != null)
            {
                _next.HandleExpense(expense);
            }
        }
    }
}
