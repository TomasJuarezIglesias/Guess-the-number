using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumber
{
    public class GenerarNumeroBot : CentroOperaciones
    {
        public void Generar()
        {
            Random numeroRandom = new Random();
            NumeroBot = numeroRandom.Next(0, 10);
            Console.WriteLine("El Bot ya ha escogido su numero");
        }
    }
}
