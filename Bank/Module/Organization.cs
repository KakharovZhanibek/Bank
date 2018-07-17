using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Module
{
    public class Organization : Client
    {
        public string Name { get; set; }
        public string AccountNUM { get; set; }
        public double SumOnTheAccount { get; set; }
        public Organization(string Name,string AccountNUM,double SumOnTheAccount)
        {
            this.Name = Name;
            this.AccountNUM = AccountNUM;
            this.SumOnTheAccount = SumOnTheAccount;
        }
        public override void PrintInfo()
        {
            Console.WriteLine("Название: ",Name);
            Console.WriteLine("Номер счета: ",AccountNUM);
            Console.WriteLine("Сумма на счету: ",SumOnTheAccount);
        }
    }
}
