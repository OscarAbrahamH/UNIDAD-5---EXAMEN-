using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema1_Bubble_Sort
{
    class Burbuja
    {
        int[] Vector; //Declarar vector
        int n; //funciona para declarar el tamaño del vector
        int X; //funciona para gregar valor a los elementos del vector
        
        public void Cargar()
        {
            Console.WriteLine("-------------Metodo de Burbuja-------------");
            Console.Write("Tamaño del Vector: "); //Se pide el tamaño del vector, asi se identifica cuantos numeros tocara ingresar
            n = int.Parse(Console.ReadLine());
            Vector = new int[n];
            Console.WriteLine("------------------------------------");

            for (int f = 0; f< Vector.Length; f++) //ingresar valor a los elementos
            {
                Console.Write("Ingrese elemento " + (f + 1) + ": "); //Agregar valor a los elementos solo son validos 0, 1, 2
                X = int.Parse(Console.ReadLine());//Agregar valor a X
                if (X > 2 || X < 0) //Rango de numeros que se puede ingresar
                {
                    Console.WriteLine(" -> No es un valor valido");  //Desplegar mensaje si el valor no es valido
                    Console.Write("Ingrese elemento " + (f + 1) + ": "); //Vuelve a preguntar el valor
                    X = int.Parse(Console.ReadLine()); //Vuelve a ingresar valor a X si fue invalido el anterios
                }
                Vector[f] = X;
            }
        }

        public void ImprimirVectorSinOrdenar()
        {
            Console.WriteLine("\n");
            //--------------VECTOR SIN ORDENAR---------------
            Console.WriteLine("Vector sin Ordenar: "); //Imprime vector sin ordenar
            for (int f = 0; f < Vector.Length; f++)
            {
                Console.Write(Vector[f] + "  ");
            }
        }

        public void ProcesoBurbuja()
        { //Se realiza un proceso de acomodamiento 
            int aux;
            for (int x = 1; x < Vector.Length; x++)
                for (int i = Vector.Length - 1; i >= x; i--)
                {
                    if (Vector[i - 1] > Vector[i]) //Acomodara los numeros menores de lado izquierdo y los mayores del derecho
                    {
                        aux = Vector[i - 1];
                        Vector[i - 1] = Vector[i];
                        Vector[i] = aux;
                    }
                }
        }

        public void ImprimirVectorOrdenado()
        { 
            //-----------------VECTOR ORDENADO------------------
            Console.WriteLine("\n");
            Console.WriteLine("Vector Ordenado: "); //Imprimir vector ordenado
            for (int f = 0; f < Vector.Length; f++)
            {
                Console.Write(Vector[f] + "  ");
            }

            Console.ReadKey();
        }

    }
}
