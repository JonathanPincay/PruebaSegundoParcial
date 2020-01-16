using System;
using System.Collections.Generic;
using System.Text;

namespace Observador
{
    //Si vamos a tener a varios sujeto se puede 
    //crear una interfaz Isujeto.
    class Sujeto
    {
        //
        private List<Iobservador19> observadores = new List<Iobservador19>();
        private string mensaje;
        private Random rnd = new Random();
        private int n;

        public int N { get => n; set =>n= value; }
        public void Suscribir(Iobservador19 suscrito)
        {
            //Recomendable poner codigo de seguridad
            observadores.Add(suscrito);
        }
        public void Desuscribir(Iobservador19 suscrito)
        {
            //Recomendable poner codigo de seguridad
            observadores.Remove(suscrito);
        }
        private void Notificar()
        {
            //Notificacionn el nuevo estado a todos los observadores
            //que esten suscrito.
            foreach(Iobservador19 o in observadores)
            {
                o.Update(mensaje);
                //o.UpdatePull();
            }

        }
        //Aqui simulamos el trabajo del observador y un cambio de estado
        //que necesita ser notificado.
        public void Trabajo()
        {
            N = rnd.Next(10);

            if(N%2==0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Nuevo estado valido");
                mensaje = string.Format("El nuevo valor es {0}", N);
                Notificar();
            }
        }
    }
}
