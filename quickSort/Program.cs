using System;
using System.Diagnostics;

namespace quickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            string arreglo = "", resultado="", resultado2 = "";
            int[] a = { 1,2,3,4,8,6,5,4,9 }; //1, 5, 3, 6, 4, 2, 9, 1, 8, 7
            Console.WriteLine("Arreglo precargado ");
            for (int i = 0; i < a.Length; i++)
            { 
                int x = 0;
                x = a[i];
                Console.Write('|'+x.ToString()+'|');
    
            }
            QuickSort(a);
            Console.WriteLine("\n\nArreglo precargado ordenado ");
            for (int i = 0; i < a.Length; i++)
            {
                arreglo = arreglo + '|' + a[i] + '|';
            }

            Console.WriteLine(arreglo);

            //aleatorios

            Console.WriteLine("\n\n\nArreglo aleatorio");

            Stopwatch tim = new Stopwatch();
            tim.Start();

            Random numero = new Random();

            int Tamano = numero.Next(50000, 80050);
            int[] Arreglo = new int[Tamano];
            Console.WriteLine("Tamaño del arreglo "+Tamano.ToString()+"\n\n");
            for (int i = 0; i < Arreglo.Length; i++)
            {
                //bool bandera = false;
                int Ente;
                Ente = numero.Next(0, 1400);
                for (int x = 0; x < Arreglo.Length; x++)
                {
                    /*
                    if(Arreglo[x] == Ente)
                    {
                        bandera = false;
                        break;
                    }
                    else
                    {
                        bandera = true;
                    }
                    */
                    Arreglo[i] = Ente;
                }
                /*
                if(bandera == true)
                {
                    Arreglo[i] = Ente;
                }
                else
                {
                    i--;
                }
                */
            }
           
            for (int i = 0; i < Arreglo.Length; i++)
            {
                resultado = resultado + ',' + Arreglo[i] ;
            }
            Console.WriteLine(resultado);
            QuickSort(Arreglo);

            Console.WriteLine("\n\n Arreglo ya ordenado\n\n");

            for (int i = 0; i < Arreglo.Length; i++)
            {
                resultado2 = resultado2 + ',' + Arreglo[i] ;
            }
            Console.WriteLine("\n"+resultado2+"\n");

            Console.WriteLine("Fin del arreglo aleatorio");
            //
            tim.Stop();
            Console.WriteLine($"Tiempo: {tim.Elapsed} s");
            Console.ReadKey();

        }
        static void QuickSort(int[] a)
        {
            QuickSort(a, 0, a.Length - 1);
        }

        static void QuickSort(int[] arreglo, int start, int end)
        {


            if (start >= end)
            {
                return;
            }

            int num = arreglo[start];

            int i = start, j = end;

            while (i < j)
            {
                while (i < j && arreglo[j] >= num)
                {
                    j--;
                }

                arreglo[i] = arreglo[j];

                while (i < j && arreglo[i] <= num)
                {
                    i++;
                }

                arreglo[j] = arreglo[i];
            }

            arreglo[i] = num;
            QuickSort(arreglo, start, i - 1);
            QuickSort(arreglo, i + 1, end);

        }


        
    }
}

