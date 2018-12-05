using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema2_Radix
{
    class Ejercicio2
    {
        static void Main(string[] args)
        {
            MetodoRadix figura1 = new MetodoRadix(); //Declaracion de la clase (En donde esta el Metodo Radix), en este caso externa
            Random Random1 = new Random(); //Declaracion del metodo Random

            int[] VectorRandom = new int[80]; //Se define el Vector Random y su tamaño

            for (int i = 0; i < 80; i++) //Tope del vector
            {
                VectorRandom[i] = Random1.Next(0, 10) + i; //Se deciden los numeros random en este caso su rango es de 0 al 10
            }
            //---------Valores sin ordenar-----------
            Console.WriteLine("Valores sin ordenar: ");

            foreach (var item in VectorRandom) //Imprime el vector de numeros random sin ordenar
            {
                Console.Write(" " + item); //Impresion
            }
            Console.WriteLine("\n");

            figura1.Radix(VectorRandom); //Se carga el objeto "Radix" y se carga en el vector Random

            //---------Valores Ordenados-----------
            Console.WriteLine("\n");
            Console.WriteLine("Valores Ordenados: ");

            foreach (var item in VectorRandom) //Se imprime el vector random ya ordenado
            {
                Console.Write(" " + item);

            }

            Console.ReadKey();
        
       }
    }
}
