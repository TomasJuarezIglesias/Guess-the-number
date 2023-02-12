using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumber
{
    public class TurnoJugador : CentroOperaciones
    {
        public bool Turno()
        {
            ComparacionJugadores comparacionJugadores = new ComparacionJugadores();


            Console.Clear();
            Console.WriteLine("===========================================================");
            Console.WriteLine($"La cantidad de intentos actual es de: {CantidadIntentos}");
            Console.WriteLine("Ingrese un numero... ");
            string? numero = Console.ReadLine();
            if (numero == null)
            {
                Console.WriteLine("Ingrese un valor valido del 0 - 10");
                return Turno();
            }
            int numeroIngresado = int.Parse(numero);
            if (numeroIngresado > 10 || numeroIngresado < 0)
            {
                Console.WriteLine("Ingrese un valor valido del 0 - 10");
                return Turno();
            }
            NumeroJugador = numeroIngresado;
            bool sonIguales = comparacionJugadores.Comparacion();
            if (!sonIguales)
            {
                Console.WriteLine("===========================================================");
                Console.WriteLine("Presione cualquier tecla para un nuevo intento...");
                Console.ReadKey();
                return Turno();
            }

            return true;
        }
    }
}
