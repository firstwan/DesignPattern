using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Facade.BankOperation
{
    class BankAccountFacade
    {
        private int accountNumber;
        private int securityCode;

        AccountNumberCheck accountChecker;
        SecurityCodeCheck codeChecker;
        FundsCheck fundChecker;

        WelcomeToBank bankWelcome;

        public BankAccountFacade(int AccountNum, int secCode)
        {
            this.accountNumber = AccountNum;
            this.securityCode = secCode;

            bankWelcome = new WelcomeToBank();
            accountChecker = new AccountNumberCheck();
            codeChecker = new SecurityCodeCheck();
            fundChecker = new FundsCheck();
        }

        public int getAccountNumber()
        {
            return accountNumber;
        }
        public int getSecurityCode() {
            return securityCode;
        }

        public void withdrawalCash(double cashToGet)
        {
            if (accountChecker.accountAvtive(getAccountNumber()) && 
                codeChecker.isCodeCorrect(getSecurityCode()) &&
                fundChecker.haveEnoughMoney(cashToGet))
            {
                Console.WriteLine("Transaction Complete\n");
            }
            else
            {
                Console.WriteLine("Transaction Failed\n");
            }
        }

        public void depositCash(double cashToDeposit)
        {
            if (accountChecker.accountAvtive(getAccountNumber()) &&
                codeChecker.isCodeCorrect(getSecurityCode()))
            {
                fundChecker.deposit(cashToDeposit);
                Console.WriteLine("Transaction Complete\n");
            }
            else
            {
                Console.WriteLine("Transaction Failed\n");
            }
        }
    }
}
