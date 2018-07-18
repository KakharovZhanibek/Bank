using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Module
{
    public class Depositor : Client
    {
        public double SizeOfInvest { get; set; }
        public double PercentByInvest { get; set; }

        public Depositor(double SizeOfInvest, double PercentByInvest)
        {
            this.SizeOfInvest = SizeOfInvest;
            this.PercentByInvest = PercentByInvest;
        }

        public override void PrintInfo()
        {
            Console.WriteLine("______________");
            Console.WriteLine("Имя: {0}",FIO);
            Console.WriteLine("Возраст: {0}",Age);
            Console.WriteLine("Адрес: {0}", address);
            Console.WriteLine("Дата вклада: {0}", DateOfStart);
            Console.WriteLine("Размер вклада: {0}", SizeOfInvest);
            Console.WriteLine("Процент вклада: "+ PercentByInvest + "%");
            Console.WriteLine("______________");
        }
        //public override string ToString()
        //{
        //    return string.Format("Вкладчик\nФ.И.О.: {0}  {1} \nВозраст: {2} Адрес: {3}\n")
        //}
    }
}