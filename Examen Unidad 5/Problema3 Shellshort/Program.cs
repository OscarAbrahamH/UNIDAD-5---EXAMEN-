using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problema3_Shellshort;

namespace Problema3_Shellshort
{
    class Ejercicio3
    {
        static void Main(string[] args)
        {
            Shell figura1 = new Shell(); //Declaracion del objeto 
            figura1.CargaNumeros(); //Se el primer proceso
            figura1.MetodoShell(); //Se carga el segundo proceso
        }
    }
}
