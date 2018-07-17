using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Module
{
    public class Creditor : Client
    {
        public double SizeOfCredit { get; set; }
        public double PercentOfCredit { get; set; }
        public double RemainOfCredit { get; set; }

        public Creditor(double SizeOfCredit,double PercentOfCredit,double RemainOfCredit)
        {
            this.SizeOfCredit = SizeOfCredit;
            this.PercentOfCredit = PercentOfCredit;
            this.RemainOfCredit = RemainOfCredit;
        }

        public override void PrintInfo()
        {
            Console.WriteLine("Размер кредита: ",SizeOfCredit);
            Console.WriteLine("Процент кредита: ",PercentOfCredit);
            Console.WriteLine("Остаток кредита: ",RemainOfCredit);
        }
    }
}
