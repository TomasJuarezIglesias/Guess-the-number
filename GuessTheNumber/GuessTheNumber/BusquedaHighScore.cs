using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumber
{
    public class BusquedaHighScore: CentroOperaciones
    {
        const string archivo = "HighScore.txt";
        public int Busqueda()
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

    }
}
