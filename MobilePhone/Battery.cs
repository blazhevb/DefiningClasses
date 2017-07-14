using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone
{
    public class Battery
    {
        public string model = "A1341251D";
        public int idleTime = 36;
        public int talkTime = 8;
        public string batteryType = EnumBatterytype.LiIon.ToString();
    }
}
