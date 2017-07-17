using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone
{
    public class Display
    {
        private int size;
        private int colors;

        public Display() : this(35, 256000)
        {

        }

        public Display(int size, int colors)
        {
            this.size = size;
            this.colors = colors;
        }

        public int Size
        {
            get
            {
                return size;
            }
            set
            {
                if(size > 1 && size <= 12)
                {
                    size = value;
                }
            }
        }

        public int Colors
        {
            get
            {
                return colors;
            }
            set
            {
                if (colors > 1 && colors <= 12)
                {
                    colors = value;
                }
            }
        }
    }
}
