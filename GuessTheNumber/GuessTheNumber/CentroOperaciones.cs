using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumber
{
    public class CentroOperaciones
    {
        readonly string archivo = "HighScore.txt";
        public int NumeroBot { get; set; }
        public int NumeroJugador { get; set; }  
        public int HighScore { get; set; }

        public int CantidadIntentos = 1;




        public bool PreguntaIniciarJuego()
        {
            Console.Clear();
            Console.WriteLine("Desea iniciar un nuevo juego? \nSi / No");
            string respuesta = Console.ReadLine();
            respuesta = respuesta.ToLower();
            if (respuesta == null || respuesta != "si" && respuesta != "no")
            {
                Console.WriteLine("Ingrese una respuesta correcta");
                return PreguntaIniciarJuego();
            }

            if (respuesta == "si")
            {
                IniciarJuego();
                return true;
            }
            Console.WriteLine("Deseaste no seguir jugando");
            return false;
        }


        public void IniciarJuego()
        {
            Console.Clear();
            BusquedaHighScore();
            Console.WriteLine("===========================================================");
            Console.WriteLine("El juego se esta iniciando...");
            GenerarNumeroBot();
            Console.WriteLine($"HighScore: {HighScore}");
            Console.WriteLine("===========================================================");
            Console.WriteLine("Presione cualquier tecla para comenzar...");
            Console.ReadKey();
            TurnoJugador();
        }

        public bool TurnoJugador()
        {
            Console.Clear();
            Console.WriteLine("===========================================================");
            Console.WriteLine($"La cantidad de intentos actual es de: {CantidadIntentos}");
            Console.WriteLine("Ingrese un numero... ");
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
            bool sonIguales = ComparacionJugadores();
            if (!sonIguales)
            {
                Console.WriteLine("===========================================================");
                Console.WriteLine("Presione cualquier tecla para un nuevo intento...");
                Console.ReadKey();
                return TurnoJugador();
            }

            return true;
        }

        public void GenerarNumeroBot()
        {
            Random numeroRandom = new Random();
            NumeroBot = numeroRandom.Next(0, 10);
            Console.WriteLine("El Bot ya ha escogido su numero");
        }

        public bool ComparacionJugadores()
        {
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
            ComparacionHighScore();
            Console.WriteLine("Haz adivinado el numero!!! Felicidades!!!");
            Console.ReadKey();
            PreguntaIniciarJuego();
            return true;
        }

        public int BusquedaHighScore()
        {
            FileStream fs = new FileStream(archivo, FileMode.Open, FileAccess.Read);
            using (StreamReader Lector = new StreamReader(fs))
            {
                string mayorPuntaje = Lector.ReadLine();
                HighScore = int.Parse(mayorPuntaje);
                Lector.Close();
                return int.Parse(mayorPuntaje);
            }
        }

        public void ComparacionHighScore()
        {
            int mayorPuntaje = BusquedaHighScore();
            if (mayorPuntaje > CantidadIntentos)
            {
               GuardarHighScore(CantidadIntentos);
            }
                           
        }

        public void GuardarHighScore(int num)
        {
            FileStream fs = new FileStream(archivo, FileMode.Truncate, FileAccess.Write);
            using (StreamWriter Escritor = new StreamWriter(fs))
            {
                Escritor.WriteLine(num);
                Escritor.Close();
            }
        }



    }
}
