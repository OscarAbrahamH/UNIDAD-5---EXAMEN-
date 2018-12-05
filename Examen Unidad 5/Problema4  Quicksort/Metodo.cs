using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema4__Quicksort
{
    class Metodo
    { 
        //VARIABLES USADAS
        int n = 29; //Se define el tamaño del vector en este caso como son 29 palabras 
        string[] Vector; //Declara el vector
        string Espacio = " "; //Espacio para las palabras
        string aux; //Guarda las palabras

        public void Carga() //metodo de proceso
        {


            //FRASE--------------------->
            Console.WriteLine("Frase: Lorem ipsum dolor sit amet, consectetur adipiscing elit. Fusce varius, ");
            Console.WriteLine("augue vitae tincidunt viverra, sem felis bibendum nisl, id cursus diam leo sit amet urna. Duis ac massa est.");
            Console.WriteLine("---------------------------------------------------");
            //Ingresa palabras
            Console.WriteLine("Solo se pueden ingresar " + n + " Palabras"); //pide palabras
            Vector = new string[n]; //Se define el rango del vector de 29
            Console.WriteLine("---------------------------------------------------");
            for (int f = 0; f < Vector.Length; f++) //repeticion para ingresar palabras 29 veces
            {
                Console.Write("Ingresa palabra #" + (f + 1) + ": "); //Pide palabras
                aux = Console.ReadLine(); //Guarda palabra ingresada en aux
                Vector[f] = aux; //Vector en auxiliar
            }
        }

        public void ProcesoMetodo() //Se realiza el metodo
        {
            {
                for (int f = 1; f < Vector.Length; f++) 
                {
                    for (int i = 0; i < Vector.Length - f; i++)
                    {
                        if (Vector[i].CompareTo(Vector[i + 1]) > 0) // Compara cual es primero y cual segundo
                        {
                            Espacio = Vector[i];
                            Vector[i] = Vector[i + 1];
                            Vector[i + 1] = Espacio;
                        }
                    }
                }
            }

            {
                Console.WriteLine("--------------------------------");
                Console.WriteLine("Frase Ordenada: "); 
                for (int f = 0; f < Vector.Length; f++) //Desplega frase despues de aplicar el metodo
                {
                    Console.Write(Vector[f] + " "); //Imprime
                }
            }
            Console.ReadKey();
        }
    }
}

