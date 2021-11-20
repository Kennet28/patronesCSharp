using System;

namespace Prototype
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Cuenta c = new Cuenta();
            Cuenta cuentaClone = (Cuenta)c.clonar();

            if(cuentaClone != null){
                Console.WriteLine(cuentaClone.cadena());
            }
            
            Console.WriteLine(cuentaClone == c);
        }
    }
}
