using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumber
{
    public class ComparacionHighScore: CentroOperaciones
    {
        public void Comparacion()
        {
            BusquedaHighScore BusquedaHighScore = new BusquedaHighScore();
            GuardarHighScore guardarHighScore = new GuardarHighScore();

            int mayorPuntaje = BusquedaHighScore.Busqueda();
            if (mayorPuntaje > CantidadIntentos)
            {
                guardarHighScore.Guardar(CantidadIntentos);
            }
        }
    }
}
