using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone
{
    class Program
    {
        static void Main(string[] args)
        {
            GSM gsm = new GSM(new Display(17, 234532511), new Battery());
            Console.WriteLine(gsm.model);
            Console.WriteLine(gsm.manufacturer);
            Console.WriteLine(gsm.price);
            Console.WriteLine(gsm.owner);
            Console.WriteLine(gsm.battery.batteryType);
            Console.WriteLine(gsm.battery.talkTime);
            Console.ReadLine();
        }

        public override string ToString()
        {

            return base.ToString();
        }
    }
}
