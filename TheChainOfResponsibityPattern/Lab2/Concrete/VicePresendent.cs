using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheChainOfResponsibityPattern.Lab2.Abstract;
using TheChainOfResponsibityPattern.Lab2.Model;

namespace TheChainOfResponsibityPattern.Lab2.Concrete
{
    class VicePresendent:BaseHandler
    {
        public override void HandleExpense(Expense expense)
        {
            if (expense.Amount > 1000 && expense.Amount <= 5000) Console.WriteLine("Vice presedent handle the expense..!");

            else if (_next != null) _next.HandleExpense(expense);
        }
    }
}
