using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bank.Module;
namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceClient SC = new ServiceClient();
            SC.CreateClients();
            SC.PrintClients();
            foreach (Client item in SC.FindByDate())
            {
                item.PrintInfo();
            }
        }
    }
}
