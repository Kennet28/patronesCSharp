using patronesComportamiento.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patronesComportamiento.Models
{
    public class OctObserver : IObserver
    {
        private Number num;
        public OctObserver(Number num)
        {
            this.num = num;
            this.num.add(this);
        }
        public void Update()
        {
            Console.WriteLine("Octal: " + Convert.ToString(num.getState(), 8));

        }
    }
}
