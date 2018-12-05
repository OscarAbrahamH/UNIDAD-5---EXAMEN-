using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema2_Radix
{
    class MetodoRadix
    { 
        int X, X2; //Declaracion de variables del metodo
        public void Radix(int[] Metodo) //Creacion del metodo
        {
            int[] Vector = new int[Metodo.Length];
            for (int aux = 31; aux > -1; --aux) //Comparacion 
            {
                X2 = 0;
                for (X = 0; X < Metodo.Length; ++X) //Comparacion que numero es menor
                {
                    bool Mover = (Metodo[X] << aux) >= 0; //Acomodo de numeros
                    if (aux == 0 ? !Mover : Mover)
                        Metodo[X - X2] = Metodo[X];
                    else
                        Vector[X2++] = Metodo[X];
                }

                Array.Copy(Vector, 0, Metodo, Metodo.Length - X2, X2);
            }
        }
    }
}
