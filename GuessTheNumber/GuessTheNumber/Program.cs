using System;
using System.Security.Cryptography;

namespace GuessTheNumber // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CentroOperaciones GestorOperaciones = new CentroOperaciones();

            GestorOperaciones.PreguntaIniciarJuego();
  
        }
    }
}