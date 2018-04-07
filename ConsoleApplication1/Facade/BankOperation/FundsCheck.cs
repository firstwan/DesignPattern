using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Facade.BankOperation
{
    class FundsCheck
    {
        private double cashInAccount = 1000.00;

        public double GetCashInAccount() { return cashInAccount; }

        public void withdrawal(double amountWithdrawal)
        {
            cashInAccount -= amountWithdrawal;
        }

        public void deposit(double amountDeposit)
        {
            cashInAccount += amountDeposit;
            Console.WriteLine("Deposit complete: Current Balance: " + cashInAccount);
        }

        public bool haveEnoughMoney(double amountWithdrawal)
        {
            if(amountWithdrawal > GetCashInAccount())
            {
                Console.WriteLine("Error: You don't have enough money");
                Console.WriteLine("Current Balance: " + cashInAccount);
                return false;
            }
            else
            {
                withdrawal(amountWithdrawal);
                Console.WriteLine("Withdrawal complete: Current Balance: " + cashInAccount);

                return true;
            }
        }
        
    }
}
