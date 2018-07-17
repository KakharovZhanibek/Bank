using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneratorName;
namespace Bank.Module
{
    class ServiceClient
    {
        static List<Client> Clients;
        static ServiceClient()
        {
            Clients = new List<Client>();
        }
        public void CreateClients()
        {
            Random rnd = new Random();
            Random rnd2 = new Random();
            Generator gen = new Generator();
            for (int i = 0; i < rnd.Next(50, 150); i++)
            {
                int x = rnd2.Next(3);
                if (x == 1)
                {
                    Depositor depositor = new Depositor(rnd.Next(1000, 5000000), rnd.Next(3, 7));

                    depositor.FIO = gen.GenerateDefault((Gender)rnd.Next(2))
                        .Replace("<center><b><font size=7>", "")
                        .Replace("</font></b></center>", "")
                        .Replace("\n", "")
                        .Substring(1);
                    depositor.DateOfStart = DateTime.Now.AddMonths(rnd.Next(1, 50));
                    depositor.Age = rnd.Next(18, 100);
                    depositor.address = "IDK";
                    Clients.Add(depositor);
                }
                else if (x == 2)
                {
                    int y=rnd.Next(1000, 1000000);
                    Creditor creditor = new Creditor(y, rnd.Next(3, 7), y - rnd.Next(1, y - 1));

                    creditor.FIO = gen.GenerateDefault((Gender)rnd.Next(2))
                        .Replace("<center><b><font size=7>", "")
                        .Replace("</font></b></center>", "")
                        .Replace("\n", "")
                        .Substring(1);
                    creditor.DateOfStart = DateTime.Now.AddMonths(rnd.Next(1, 50));
                    creditor.Age = rnd.Next(18, 100);
                    creditor.address = "Address"+rnd.Next(10,100).ToString();
                    Clients.Add(creditor);
                }
                else if (x == 3)
                {
                    Organization organization = new Organization(("Organization"+rnd.Next(0,100)),"Num_"+rnd.Next(0,100000).ToString(),rnd.Next(5000,10000000));
                    organization.DateOfStart = DateTime.Now.AddMonths(rnd.Next(1, 50));
                    organization.address = "Адрес #" + rnd.Next(10, 100000).ToString();
                    Clients.Add(organization);
                }
            }
        }
        public void PrintClients()
        {
            foreach (Client item in Clients)
            {
                Console.WriteLine();
            }
        }
    }
}
