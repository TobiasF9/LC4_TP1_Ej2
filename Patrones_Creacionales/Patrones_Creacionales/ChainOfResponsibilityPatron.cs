using System;
using System.Collections.Generic;
using System.Text;

namespace Patrones_Creacionales
{
    
    public interface IExpenseHandler
    {
        IExpenseHandler SetNext(IExpenseHandler handler);

        bool ApproveExpense(Expense expense);
    }

    abstract class AbstractExpenseHandler : IExpenseHandler
    {
        private IExpenseHandler _nextHandler;

        public IExpenseHandler SetNext(IExpenseHandler handler)
        {
            this._nextHandler = handler;
            return handler;
        }

        public virtual bool ApproveExpense(Expense expense)
        {
            if (this._nextHandler != null)
            {
                return this._nextHandler.ApproveExpense(expense);
            }
            else
            {
                return false;
            }
        }
    }

    class ManagerExpenseHandler : AbstractExpenseHandler
    {
        //_approvalLimit tiene un límite según el cargo
        private decimal _approvalLimit = 1000;

        public override bool ApproveExpense(Expense expense)
        {
            if (expense.Amount <= _approvalLimit)
            {
                Console.WriteLine($"Manager approved expense of ${expense.Amount} for {expense.Purpose}.");
                return true;
            }
            else
            {
                return base.ApproveExpense(expense);
            }
        }
    }

    class DirectorExpenseHandler : AbstractExpenseHandler
    {
        private decimal _approvalLimit = 5000;

        public override bool ApproveExpense(Expense expense)
        {
            if (expense.Amount <= _approvalLimit)
            {
                Console.WriteLine($"Director approved expense of ${expense.Amount} for {expense.Purpose}.");
                return true;
            }
            else
            {
                return base.ApproveExpense(expense);
            }
        }
    }

    class CEOExpenseHandler : AbstractExpenseHandler
    {
        public override bool ApproveExpense(Expense expense)
        {
            Console.WriteLine($"CEO approved expense of ${expense.Amount} for {expense.Purpose}.");
            return true;
        }
    }

    public class Expense
    {
        public string Purpose { get; set; }
        public decimal Amount { get; set; }
    }

}
