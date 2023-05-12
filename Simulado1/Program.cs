using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulado1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Simulado 1 ex 3");
            List<int> lista = new List<int>() { 5, 2, 10, 7, 1, 4, 7, 8, 6, 3 };
            int[] numeros = { 5, 2, 10, 7, 1, 4, 7, 8, 6, 3 }; // sem 9
            Console.WriteLine("Sequencia a ser ordenada: ");
            foreach (int numero in lista)
            {
                Console.Write(" " + numero);
            }

            int cont = 0;
            while (cont != lista.Count)
            {
                for (int i = 1; i < (lista.Count); i++)
                {
                    if (lista[i] < lista[i - 1])
                    {
                        int aux = lista[i];
                        lista[i] = lista[i - 1];
                        lista[i - 1] = aux;
                    }
                }
                cont++;
            }

            Console.WriteLine("\nSequência ordenada: ");
            foreach (int numero in lista)
            {
                Console.Write(" " + numero);
            }

            Console.ReadKey();


        }
    }
}
