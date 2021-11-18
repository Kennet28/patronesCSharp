using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace RefactoringGuru.DesignPatterns.Singleton.Conceptual.NonThreadSafe
{
    // La clase Singleton define el método `GetInstance` que sirve como
    // alternativa al constructor y permite a los clientes acceder a la misma instancia de
    // esta clase una y otra vez.
    // ES: El Singleton siempre debe ser una clase 'sellada' para evitar la clase
    // herencia a través de clases externas y también a través de clases anidadas.
    public sealed class Singleton
    {
        // El constructor de Singleton siempre debe ser privado para evitar
        // llamadas de construcción directas con el operador `new`.
        private Singleton() { }
        // La instancia de Singleton se almacena en un campo estático. Hay hay
        // múltiples formas de inicializar este campo, todas tienen varios pros
        // y contras. En este ejemplo, mostraremos la más simple de estas formas,
        // que, sin embargo, no funciona muy bien en programas multiproceso.
        private static Singleton _instance;
        // Este es el método estático que controla el acceso al singleton
        // instancia. En la primera ejecución, crea un objeto singleton y coloca
        // en el campo estático. En ejecuciones posteriores, devuelve el cliente.
        // objeto existente almacenado en el campo estático.
        public static Singleton GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Singleton();
            }
            return _instance;
        }
        // Finalmente, cualquier singleton debe definir alguna lógica de negocios, que puede
        // se ejecutará en su instancia.
        public static void someBusinessLogic()
        {
           
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // The client code.
            Singleton s1 = Singleton.GetInstance();
            Singleton s2 = Singleton.GetInstance();

            //pide datos al usuario para la proxima validación
            Console.WriteLine("Type User");
            String UserId1 = Console.ReadLine();
                Console.WriteLine("Type password");
                String Pass = Console.ReadLine();

                String UserIdCorrect = "user";
                String PassCorrect = "password";
            //se muestra la validación con un if and else para el mensaje que nos arrojara.
            if (s1 == s2 && UserId1 != UserIdCorrect && Pass != PassCorrect)
            {

                Console.WriteLine("contraseña o usuario incorrectos");


            }


            else
            {
                Console.WriteLine("sesion iniciada");
            }

        }
    }
}
