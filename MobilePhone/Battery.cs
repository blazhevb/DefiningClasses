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
        public string batteryType = EnumBatterytype.LiIon.ToString();

        private int idleTime = 36;
        private int talkTime = 8;

        public Battery(int idleTime, int talkTime, EnumBatterytype batteryType)
        {
            this.idleTime = idleTime;
            this.talkTime = talkTime;
            this.batteryType = batteryType.ToString();
        }

        public int Idletime
        {
            get
            {
                return idleTime;
            }
            set
            {
                if(idleTime > 0 && idleTime < 56)
                {
                    idleTime = value;
                }
            }
        }

        public int TalkTime
        {
            get
            {
                return talkTime;
            }
            set
            {
                if (talkTime > 0 && talkTime < 56)
                {
                    talkTime = value;
                }
            }
        }
    }
}
