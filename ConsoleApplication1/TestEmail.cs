using Newtonsoft.Json;
using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class TestEmail
    {
        static void Main1()
        {
            string json = @"{
                            'Email': 'testing@example.com',
                            'Active': true,
                            'CreatedDate': '2013-01-20T00:00:00Z',
                           'Roles': [
                             'User',
                             'Admin'
                           ]
                         }";

            Account account = JsonConvert.DeserializeObject<Account>(json);

            Console.WriteLine(account.Email);
            // james@example.com
            Console.Read();
        }
    }

    public class Account
    {
        public string Email { get; set; }


        public IList<string> Roles { get; set; }
        public string extraItem { get; set; }
    }
}
