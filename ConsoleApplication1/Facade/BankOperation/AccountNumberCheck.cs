using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Facade.BankOperation
{
    class AccountNumberCheck
    {
        private int accountNumber = 123456789;
        public int GetAccountNumber()
        {
            return accountNumber;
        }

        public void setAccountNumber(int accNum)
        {
            this.accountNumber = accNum;
        }

        public bool accountAvtive(int accNumToCheck)
        {
            if(accNumToCheck == GetAccountNumber())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
