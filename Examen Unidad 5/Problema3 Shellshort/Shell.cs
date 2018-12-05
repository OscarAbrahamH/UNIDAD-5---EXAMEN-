using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problema3_Shellshort;

namespace Problema3_Shellshort
{
    class Shell
    {
        int n; //Variable "n" para pedir numeros
        int x = 0; //Se utiliza en el proceso de Shell
        int aux = 0;  //Se utiliza en el proceso de Shell
        int aux2 = 0; //Se utiliza en el proceso de Shell
        int Variable = 0; //Se utiliza en el proceso de Shell
        int[] Vector; //Se declara el vector

        public void CargaNumeros()
        {
            Console.Write("Tamaño del Vector: "); //Pide que ingreses el numero del vector
            string linea;
            linea = Console.ReadLine(); 
            n = int.Parse(linea); //Se guarda el numero de "n"
            Vector = new int[n];
            for (int f = 0; f < Vector.Length; f++)
            {
                Console.Write("Ingrese elemento " + (f + 1) + ": "); //Pide valores 
                linea = Console.ReadLine();
                Vector[f] = int.Parse(linea); //Guarda el valor
            }
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("VECTOR SIN ORDENAR"); //Imprime el vector sin ordenar
            for (int i = 0; i < Vector.Length; i++) //con un for imprime cada numero del vector
            {
                Console.Write("{0} ", Vector[i]); //Impresion
            }
        }

        public void MetodoShell() //Metodo Shell
        {
            Variable = Vector.Length / 2; 
            while (Variable > 0) //Se hace una comparacion
            {
                aux2 = 1;
                while (aux2 != 0)
                {
                    aux2 = 0;
                    x = 1;
                    while (x <= (Vector.Length - Variable)) //Se aplica el proceso Shell
                    {
                        if (Vector[x - 1] > Vector[(x - 1) + Variable])
                        {
                            aux = Vector[(x - 1) + Variable];
                            Vector[(x - 1) + Variable] = Vector[x - 1];
                            Vector[(x - 1)] = aux;
                            aux2 = 1;
                        }
                        x++;
                    }
                }
                Variable = Variable / 2;
            }

            Console.WriteLine("\n");
            Console.WriteLine("VECTOR ORDENADO");
            for (int i = 0; i < Vector.Length; i++)  //Imprime el proceso ordenado
            {
                Console.Write("{0} ", Vector[i]); //Impresion
            }
            Console.ReadKey();
        }
    }
}
