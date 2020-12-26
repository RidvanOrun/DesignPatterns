using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheChainOfResponsibityPattern.Lab2.Model;

namespace TheChainOfResponsibityPattern.Lab2.Abstract
{
    public abstract class BaseHandler
    {
        protected BaseHandler _next;

        public void SetHandler(BaseHandler next) => _next = next;

        public abstract void HandleExpense(Expense expense);
    }
}
