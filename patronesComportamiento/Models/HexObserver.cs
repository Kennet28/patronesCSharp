using patronesComportamiento.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patronesComportamiento.Models
{
    public class HexObserver : IObserver
    {
        private Number num;
        public HexObserver(Number num)
        {
            this.num = num;
            this.num.add(this);
        }

        public void Update()
        {
            Console.WriteLine("Hexadecimal: " + Convert.ToString(num.getState(), 16));
        }
    }
}
