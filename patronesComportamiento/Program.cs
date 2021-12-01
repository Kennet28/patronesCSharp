using patronesComportamiento.Models;

namespace patronesComportamiento
{
    class Program
    {
        static void Main(string[] args)
        {
            Number number = new Number();
            new HexObserver(number);
            new BinObserver(number);
            new OctObserver(number);
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingresa un numero");
                int num = int.Parse(Console.ReadLine()!);
                number.setState(num);
            }
        }
    }
}
