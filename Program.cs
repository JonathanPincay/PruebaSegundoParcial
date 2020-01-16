using System;

namespace Observador
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creamos el sujeto 
            Sujeto miSujeto = new Sujeto();

            //Creamos a los observadores
            Observador a = new Observador("A", miSujeto);
            Observador b = new Observador("B", miSujeto);
            Observador c = new Observador("C", miSujeto);

            //Trabajamos.
            for (int n = 0; n < 5; n++)
                miSujeto.Trabajo();

            //Alguien se sale de la lista. 
            Console.WriteLine("DESCRIBIR");
            miSujeto.Desuscribir(b);

            //Trabajamos..
            for (int n = 0; n < 5; n++)
                miSujeto.Trabajo();


            Console.ReadKey();

        }
    }
}
