using SteamDAL.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SteamDAL
{
    public  class ConsoleProgram : BaseController
    {
       public static string test()
        {
           return ExecuteGetRequest(null,"Accounts");
        }

       
        [STAThread]
        static void Main()
        {
            Console.WriteLine(test());
        }
    }
}
