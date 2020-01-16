using System;
using System.Collections.Generic;
using System.Text;

namespace Observador
{
    class Observador : Iobservador19

    {
        private string nombre;
        private Sujeto sujeto;
        
        public Observador (string pNombre, Sujeto pSujeto)
        {
            nombre = pNombre;
            sujeto = pSujeto;
            sujeto.Suscribir(this);
        }
        
        public void Update(string mensaje)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Push, {0} - {1}", nombre, mensaje);
        }
        //Aqui es para el caso pull
        public void UpdatePull()
        {
            //Obtenemos del sujeto
            int n = sujeto.N;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Push, {0}-{1}", nombre, n);
        }
    }
}
