using System;
using System.Collections.Generic;
using System.Text;

namespace TareaMatrizEstructura
{
    //La tarea propuesta para este ejercicio es la siguiente:
    //Elaborar una matriz de 2 filas y 5 columnas.Realizar la carga de componentes por columna(es decir primero ingresar tod
    //a la primer columna, luego la segunda columna y así sucesivamente)
    //Imprimir luego la matriz.
    class Matriz
    {
        private int[,] matriz;

        //Cargar los valores que tendra la matriz
        public void Cargar()
        {
            matriz = new int[2, 5];

            for (int i = 0; i < 5; i++)
            {
                for (int c = 0; c < 2; c++)
                {
                    Console.Write("Digite el valor para la matriz: ");
                    string linea = Console.ReadLine();
                    matriz[c, i] = int.Parse(linea);
                }
            }
        }

        //Mostrar los valores de la matriz (2,5)
        public void Mostrar()
        {
            for (int i = 0; i < 2; i++)
            {
                for (int c = 0; c < 5; c++)
                {
                    Console.Write(matriz[i, c] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
