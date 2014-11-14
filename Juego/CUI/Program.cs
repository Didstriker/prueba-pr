using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RabadanD.Programacion.Eval1.Juego.Logica;

namespace RabadanD.Programacion.Eval1.Juego.CUI
{
    class Program
    {
        static void Main()
        {
            int secreto = ModeloJuego.SecretoDeLaLife();
            Console.WriteLine("El secreto de la Laif es " + secreto);
            Console.ReadLine();
        }
    }
}
