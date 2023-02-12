using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumber
{
    public class GuardarHighScore
    {
        const string archivo = "HighScore.txt";
        public void Guardar(int num)
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
