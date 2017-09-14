using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone
{
    static class GSMTest
    {
        private static Random rand = new Random();
        private static GSM[] GSMs = new GSM[10];
        public static void CreateGSMs()
        {
            for (int i = 0; i < 10; i++)
            {
                GSMs[i] = new GSM("G" + rand.Next(10, 50).ToString(), "Samsung", (decimal)rand.Next(300, 900), "unknown", new Battery(rand.Next(16, 36), rand.Next(4, 16), (EnumBatterytype)rand.Next(1, 3)), new Display(rand.Next(5, 12), 123000000));
            }
        }

        public static void DisplayContent()
        {
            foreach(GSM phone in GSMs)
            {
                Console.WriteLine(phone.ToString());
            }
            Console.WriteLine(GSM.Iphone4S.ToString());
        }
    }
}
