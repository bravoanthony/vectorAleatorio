using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppVectoresAleatorios
{
    class Program
    {
   
        static void Main(string[] args)
        {
            int[] x = new int[MAX];
            leerVectores(x);
            Console.WriteLine ("\nElementos del vector");
            imprimirVectores (x);
            Console.ReadKey ();

        
        }
        public static void leerVector(int[] x)
        {
            for (int i = 0; i < MAX; i++)
            {

                var randomNumber = new Random().Next(1, 5000);
                x[i] = randomNumber;
            }
        }

        public static void imprimirVectores(int[] x)
        {
            for (int i = 0; i < MAX; i++)
            {
                Console.WriteLine(x[i]);
            }
            }
    }
}
