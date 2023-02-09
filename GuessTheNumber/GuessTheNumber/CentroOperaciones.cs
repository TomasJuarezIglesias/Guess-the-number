using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumber
{
    public class CentroOperaciones
    {
        public int NumeroBot { get; set; }
        public int NumeroJugador { get; set; }  

        public void IniciarJuego()
        {
            Console.WriteLine("El juego se esta iniciando...");
        }

        public bool TurnoJugador()
        {
            Console.WriteLine("El Bot ya ha escogido su numero");
            Console.WriteLine("Ingrese su numero... ");
            string? numero = Console.ReadLine();
            if (numero == null)
            {
                Console.WriteLine("Ingrese un valor valido del 0 - 10");
                return TurnoJugador();
            }
            int numeroIngresado = int.Parse(numero);
            if (numeroIngresado > 10 || numeroIngresado < 0)
            {
                Console.WriteLine("Ingrese un valor valido del 0 - 10");
                return TurnoJugador();
            }
            NumeroJugador = numeroIngresado;
            return true;
        }

        public void GenerarNumeroBot()
        {
            Random numeroRandom = new Random();
            NumeroBot = numeroRandom.Next(0, 10);
        }


    }
}
