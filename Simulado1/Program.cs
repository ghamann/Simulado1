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

            ////// EXERCICIO 1///////

            String palavra = ("monitor");
            char[] forca= new char[palavra.Length];
            for (int i = 0; i < palavra.Length; i++)
            {
                forca[i] = '_';
            }

            int vidas = 7;
            int acertos = 0;
            while (vidas > 0)
            {
                Console.WriteLine("Digite uma letra:");
                char letra = Console.ReadKey().KeyChar;
                Console.WriteLine("\n");

                bool contem = false;
                for (int l = 0; l < palavra.Length; l++) 
                {
                    if (palavra[l] == letra)
                    {
                        contem = true;
                    }
                }
                if (contem == true)
                {
                    Console.WriteLine("Acertou! \n");
                    for (int i = 0; i < palavra.Length; i++)
                    {
                        if (palavra[i] == letra)
                        {
                            forca[i] = letra;
                        }

                    }

                    foreach (char c in forca)
                    {
                        Console.Write(" " + c);
                    }
                    Console.WriteLine("\n");

                }
                else 
                { 
                    vidas--;
                    Console.WriteLine("Errou! ");
                    Console.WriteLine("Vidas: " + vidas);
                    if (vidas == 0) 
                    {
                        Console.WriteLine("Você morreu ++++");
                    }
                }

            }

            Console.ReadKey();

            ////// EXERCICIO 2///////

            /*            Console.WriteLine("Escreva a palavra para verificar se é palindromo");
                        string palavra = Console.ReadLine().ToLower(); // para minusculas
                        palavra = palavra.Replace(" ", ""); // para retirar espaços

                        int nletras = palavra.Length;
                        int teste = 0;
                        for (int i=0; i <nletras; i++) 
                        {
                            if (palavra[i] == palavra[(nletras-1-i)]) 
                            {
                                teste++;
                                //Console.WriteLine("É palindromo");
                            }else 
                            {
                                Console.WriteLine("Não é palindromo");
                                break;
                            }
                        }
                        if (teste == nletras)
                        {
                            Console.WriteLine("É palindromo");
                        }
                        Console.ReadKey();*/


            ////// EXERCICIO 3/////// - já havia feito semelhante na lista extra (com vetor)

            /*            Console.WriteLine("Simulado 1 ex 3");
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

                        Console.ReadKey();*/


        }
    }
}
