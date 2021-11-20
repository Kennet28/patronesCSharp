using System;
namespace Singleton
{
    class Program
    {
        
        static void Main(string[] args)
        {
          UnicaInstancia miNombre = UnicaInstancia.getSingletonInstancia("Elias Gamboa");
          UnicaInstancia tuNombre = UnicaInstancia.getSingletonInstancia("Jose Perez");

          Console.WriteLine(miNombre.getNombre);
          Console.WriteLine(tuNombre.getNombre);
        }
    }

}
