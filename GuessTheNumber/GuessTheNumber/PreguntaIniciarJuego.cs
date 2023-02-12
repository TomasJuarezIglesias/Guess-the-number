using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumber
{
    public class PreguntaIniciarJuego
    {
        public bool Pregunta()
        {
            IniciarJuego iniciarJuego = new IniciarJuego();
            Console.Clear();
            Console.WriteLine("Desea iniciar un nuevo juego? \nSi / No");
            string respuesta = Console.ReadLine();
            respuesta = respuesta.ToLower();
            if (respuesta == null || respuesta != "si" && respuesta != "no")
            {
                Console.WriteLine("Ingrese una respuesta correcta");
                return Pregunta();
            }

            if (respuesta == "si")
            {
                iniciarJuego.Iniciar();
                return true;
            }
            Console.WriteLine("Deseaste no seguir jugando");
            return false;
        }
    }
}
