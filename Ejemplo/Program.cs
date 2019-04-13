using System;

namespace Ejemplo
{
    class Program
    {
        static void Main(string[] args)
        {


            Persona p = new Persona("Pepito Flores", 67);


            p.cobrar(8000);


            p.pagar(500);

            p.verSaldo();




            Persona p2 = new Persona("Jorge Rodriguez", 30);


            p2.hacerEjercicio(70);

            p2.dormir(30);


            p2.verEnergia();


            Console.ReadLine();

         

        }
    }
}
