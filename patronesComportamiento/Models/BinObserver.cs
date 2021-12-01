using patronesComportamiento.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patronesComportamiento.Models
{
    public class BinObserver : IObserver
    {
        private Number num;
        public BinObserver(Number num)
        {
           this.num = num;
            this.num.add(this);
        }
        public void Update()
        {
            Console.WriteLine("Binario: "+ Convert.ToString(num.getState(),2));
        }
    }
}
