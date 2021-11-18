using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//JUSTIFICACIÓN 
//tenemos la clase bebidacomponent que es la encargada de ser la clase abstracta con nivel mayor gerarquia que consta de
//precio y descripción como operaciones en todas las clases de este ejemplo,es decir, este ejemplo parte de la venta de
//cafe de tal modo que dependiendo el cafe que se elija y los complementos que se le agreguen a este le dara un costo final,
//ahora bien para entender este tipo de estructura tenemos como segundo lugar en la gerarquia al tipo de bebida ya sea cafe
//o té y luego sigue la clase en la gerarquia agregadodecorator y por ultimo tenemos los complementos y tecnicamente tenemos
//un patrón de diseño estructural que te permite añadir funcionalidades a objetos colocando estos objetos dentro de objetos
//encapsuladores especiales que contienen estas funcionalidades.
namespace PatronDecoratorC
{
    class Program
    {
        static void Main(string[] args)
        {

            BebidaComponent cafe = new CafeDescafeinado();
            cafe = new Crema(cafe);
            cafe = new Edulcorante(cafe);
            cafe = new Canela(cafe);

            Console.WriteLine($"Producto:  {cafe.Descripcion} tiene un costo de : ${cafe.Costo}");

            cafe = new CafeExpresso();
            cafe = new Leche(cafe);
            cafe = new Edulcorante(cafe);
            cafe = new Canela(cafe);

            Console.WriteLine($"Producto:  {cafe.Descripcion} tiene un costo de : ${cafe.Costo}");

            cafe = new CafeSolo();
            cafe = new Edulcorante(cafe);

            Console.WriteLine($"Producto:  {cafe.Descripcion} tiene un costo de : ${cafe.Costo}");


            Console.ReadKey();
        }
    }
}
