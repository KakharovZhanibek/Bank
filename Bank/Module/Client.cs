using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Module
{
    public abstract class Client
    {
        public string FIO { get; set; }
        public int Age { get; set; }
        public string address { get; set; }
        public DateTime DateOfStart { get; set; }
        
        public virtual void PrintInfo()
        {
            Console.WriteLine("Ф.И.О.: ",FIO);
            Console.WriteLine("Адрес: ",address);
            Console.WriteLine("Дата начала: ",DateOfStart);
        }
    }
}
