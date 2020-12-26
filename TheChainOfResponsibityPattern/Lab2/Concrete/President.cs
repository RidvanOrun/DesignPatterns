using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheChainOfResponsibityPattern.Lab2.Abstract;
using TheChainOfResponsibityPattern.Lab2.Model;

namespace TheChainOfResponsibityPattern.Lab2.Concrete
{
    public class President:BaseHandler
    {
        public override void HandleExpense(Expense expense)
        {
            if (expense.Amount > 5000)
                Console.WriteLine("Presedent handle the expense..!");
        }
    }
}
