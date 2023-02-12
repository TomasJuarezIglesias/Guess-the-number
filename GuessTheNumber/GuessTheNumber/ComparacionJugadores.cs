using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumber
{
    public class ComparacionJugadores : CentroOperaciones
    {
        public bool Comparacion()
        {
            ComparacionHighScore comparacionHighScore = new ComparacionHighScore();
            PreguntaIniciarJuego preguntaIniciarJuego = new PreguntaIniciarJuego();
            if (NumeroBot > NumeroJugador)
            {
                Console.WriteLine("El numero escogido por el BOT es mayor al ingresado");
                CantidadIntentos++;
                return false;
            }
            if (NumeroBot < NumeroJugador)
            {
                Console.WriteLine("El numero escogido por el BOT es menor al ingresado");
                CantidadIntentos++;
                return false;
            }
            Console.Clear();
            comparacionHighScore.Comparacion();
            Console.WriteLine("Haz adivinado el numero!!! Felicidades!!!");
            Console.ReadKey();
            preguntaIniciarJuego.Pregunta();
            return true;
        }

    }
}
