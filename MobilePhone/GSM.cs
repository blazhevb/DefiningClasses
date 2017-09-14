using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone
{
    public class GSM
    {
        private string model;
        private string manufacturer;
        private decimal price;
        private string owner;
        private Battery battery;
        private Display display;

       public static GSM iphone4S;

        

        public GSM (string model, string manufacturer, decimal price, string owner, Battery battery, Display display)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = price;
            this.owner = owner;
            this.battery = battery;
            this.display = display;
        }

        public string Model
        {
            get { return model; }
            set {
                    if (model.Length > 0)
                    {
                        model = value;
                    }
                    else model = "g253";
                }
        }

        public decimal Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }

        public static GSM Iphone4S
        {
            get
            {
                return iphone4S = new GSM("iphone4S", "Apple", 1800.00m, "Steve Jobs", new Battery(56, 20, EnumBatterytype.LiIon), new Display(10, 256000000));
            }
            set
            {
                iphone4S = value;
            }
        }

        public override string ToString()
        {
            return model + "\r\n" + manufacturer + "\r\n" + price + "\r\n" + owner + "\r\n" + battery.TalkTime + "\r\n" + battery.Idletime + "\r\n" + battery.batteryType + "\r\n" + display.Size + "\r\n" + display.Colors;
        }
    }
}
