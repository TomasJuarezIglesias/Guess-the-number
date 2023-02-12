using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumber
{
    public class IniciarJuego : CentroOperaciones
    {
        public void Iniciar()
        {
            BusquedaHighScore BusquedaHighScore = new BusquedaHighScore();
            GenerarNumeroBot generarNumeroBot = new GenerarNumeroBot();

            Console.Clear();
            BusquedaHighScore.Busqueda();
            Console.WriteLine("===========================================================");
            Console.WriteLine("El juego se esta iniciando...");
            generarNumeroBot.Generar();
            Console.WriteLine($"HighScore: {HighScore}");
            Console.WriteLine("===========================================================");
            Console.WriteLine("Presione cualquier tecla para comenzar...");
            Console.ReadKey();
            TurnoJugador();
        }
    }
}
