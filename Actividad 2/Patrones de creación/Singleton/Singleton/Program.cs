using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace RefactoringGuru.DesignPatterns.Singleton.Conceptual.NonThreadSafe
{
    

    
    public sealed class Singleton
    {
        private Singleton() { }

      
        private static Singleton _instance;

        public static Singleton GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Singleton();
            }
            return _instance;
        }

        public static void someBusinessLogic()
        {
           
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Singleton s1 = Singleton.GetInstance();
            Singleton s2 = Singleton.GetInstance();


            Console.WriteLine("Type User");
            String UserId1 = Console.ReadLine();
                Console.WriteLine("Type password");
                String Pass = Console.ReadLine();

                String UserIdCorrect = "user";
                String PassCorrect = "password";
            
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
