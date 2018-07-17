using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Module
{
    public class Depositor:Client
    {
        public double SizeOfInvest{get;set;}
        public double PercentByInvest { get; set; }

        public Depositor(double SizeOfInvest,double PercentByInvest)
        {
            this.SizeOfInvest = SizeOfInvest;
            this.PercentByInvest = PercentByInvest;
        }

        public override void PrintInfo()
        {
            Console.WriteLine("Дата вклада: ",DateOfStart);
            Console.WriteLine("Размер вклада: ",SizeOfInvest);
            Console.WriteLine("Процент вклада: ",PercentByInvest+"%");
        }
    }
}
