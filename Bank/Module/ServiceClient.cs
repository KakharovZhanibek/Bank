using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneratorName;
namespace Bank.Module
{
    public class ServiceClient
    {
        static List<Client> clients;
        static ServiceClient()
        {
            clients = new List<Client>();
        }
        public void CreateClients()
        {
            Random rnd = new Random();
            Random rnd2 = new Random();
            Generator gen = new Generator();
            for (int i = 0; i < rnd.Next(50, 150); i++)
            {
                int x = rnd2.Next(1, 4);
                if (x == 1)
                {
                    Depositor depositor = new Depositor(rnd.Next(1000, 5000000), rnd.Next(3, 7));
                    depositor.S = 1;
                    depositor.FIO = gen.GenerateDefault((Gender)rnd.Next(2))
                        .Replace("<center><b><font size=7>", "")
                        .Replace("</font></b></center>", "")
                        .Replace("\n", "")
                        .Substring(1);
                    depositor.DateOfStart = DateTime.Now.AddMonths(rnd.Next(1, 50)).AddDays(rnd.Next(1, 16));
                    depositor.Age = rnd.Next(18, 100);
                    depositor.address = "Address_" + rnd.Next(10 + 150).ToString();
                    clients.Add(depositor);
                }
                else if (x == 2)
                {
                    int y = rnd.Next(1000, 1000000);
                    Creditor creditor = new Creditor(y, rnd.Next(3, 7), y - rnd.Next(1, y - 1));
                    creditor.S = 2;
                    creditor.FIO = gen.GenerateDefault((Gender)rnd.Next(2))
                        .Replace("<center><b><font size=7>", "")
                        .Replace("</font></b></center>", "")
                        .Replace("\n", "")
                        .Substring(1);
                    creditor.DateOfStart = DateTime.Now.AddMonths(rnd.Next(1, 50)).AddDays(rnd.Next(1, 21));
                    creditor.Age = rnd.Next(18, 100);
                    creditor.address = "Address" + rnd.Next(10, 100).ToString();
                    clients.Add(creditor);
                }
                else if (x == 3)
                {
                    Organization organization = new Organization(("Organization_" + rnd.Next(0, 100)), "Num_" + rnd.Next(0, 100000).ToString(), rnd.Next(5000, 10000000));
                    organization.S = 3;
                    organization.DateOfStart = DateTime.Now.AddMonths(rnd.Next(1, 50));
                    organization.address = "#_" + rnd.Next(10, 100000).ToString();
                    clients.Add(organization);
                }
            }
        }
        public void PrintClients()
        {
            foreach (Client item in clients)
            {
                item.PrintInfo();
            }
        }
        public List<Client> FindByDate()
        {
            Console.WriteLine("Введите дату\n");
            DateTime temp = DateTime.Parse(Console.ReadLine());

            List<Client> clientsDate = new List<Client>();
            foreach (Client item in clients)
            {
                clientsDate = clients.Where
                    (w => w.DateOfStart.Day == temp.Day &&
                    w.DateOfStart.Month == temp.Month &&
                    w.DateOfStart.Year == temp.Year)
                    .ToList();
            }
            return clientsDate;
        }
    }
}