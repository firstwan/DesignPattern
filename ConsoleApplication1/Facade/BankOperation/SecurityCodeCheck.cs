using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Facade.BankOperation
{
    
    class SecurityCodeCheck
    {
        private int securityCode = 1234;
        public int GetSecurityCode() { return securityCode; }

        public bool isCodeCorrect(int secCodeToCheck)
        {
            if(secCodeToCheck == GetSecurityCode())
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
