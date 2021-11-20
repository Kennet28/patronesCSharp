using System;
public class UnicaInstancia{
    private string nombre;
    private static UnicaInstancia unicaInstancia;

    public string getNombre { get => nombre; set => nombre = value; }

    private UnicaInstancia(string nombre){
        this.nombre = nombre;
        Console.WriteLine("Hola Mundo mi nombre es: " + this.nombre);
    }
    public static UnicaInstancia getSingletonInstancia(string nombre){
        
            
        if(unicaInstancia == null){
            unicaInstancia = new UnicaInstancia(nombre);
        }else{
            Console.WriteLine("No se puede crear otro objeto debido a que ya se ha creado un objeto en la clase UnicaInstancia");
        }
        return unicaInstancia;
        }

        
    }
