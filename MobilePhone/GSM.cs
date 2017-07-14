using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone
{
    public class GSM
    {
        public string model = "g30";
        public string manufacturer = "samsung";
        public decimal price = 0.00m;
        public string owner = null;
        public Battery battery;
        public Display display;

        public GSM() : this(0.00m)
        {
            this.model = "g30";
            this.manufacturer = "samsung";
        }
        
        public GSM(decimal Price) : this(null)
        {
            this.price = Price;
        }

        public GSM(string Owner)
        {
            this.owner = Owner;
        }

        public GSM(decimal Price, string Owner)
        {
            this.price = Price;
            this.owner = Owner;
        }

        public GSM(Display displ, Battery bat)
        {
            this.display = displ;
            this.battery = bat;
        }
    }
}
