using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Facade.BankOperation
{
    class TestProgram
    {
        public static void Main1()
        {
            BankAccountFacade accessingBank = new BankAccountFacade(123456789,1234);

            accessingBank.withdrawalCash(50.00);

            accessingBank.withdrawalCash(1000.00);

            accessingBank.depositCash(50.00);

            Console.Read();
        }
    }
}
