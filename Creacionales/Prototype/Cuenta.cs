using System;
namespace Prototype
{
    public class Cuenta : ICuenta
    {
        
        private string user;
        private string pass;

        public Cuenta(){
            Console.WriteLine("Ingrese el usuario");
            user = Console.ReadLine();
            Console.WriteLine("Ingresa el password");
            pass = Console.ReadLine();
        }

        public string getPass() { 
            return pass;
        }
        public string getUser(){
            return user;
        }
        public void setPass(string pass){
            this.pass = pass;
        }
        public void setUser(String user){
            this.user = user;
        }

        public ICuenta clonar(){
            Cuenta cuenta = null;

            cuenta = (Cuenta)Clone();
                    return cuenta;
                }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public string cadena(){
            return "Cuenta: User=" + user + " Password=" + pass;
        }
    }
        }
