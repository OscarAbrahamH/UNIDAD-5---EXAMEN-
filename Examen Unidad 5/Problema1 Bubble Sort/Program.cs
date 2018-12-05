using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema1_Bubble_Sort
{
    class Ejercicio1
    {
        static void Main(string[] args)
        {
            Burbuja figura1 = new Burbuja(); //Creacion del objeto
            figura1.Cargar(); //Carga
            figura1.ImprimirVectorSinOrdenar(); //Imprimir vector no ordenado
            figura1.ProcesoBurbuja(); //Proceso
            figura1.ImprimirVectorOrdenado(); //Imprimir vector ordenado
        }
    }
}
