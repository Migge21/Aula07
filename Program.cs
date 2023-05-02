using System;
using System.Drawing;
using System.Runtime.Intrinsics.X86;

namespace Aula07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Aula 7.  - Data:02/05  
               Lab. J1 207 - Algoritmos e Técnicas de Programação – 4/2023

               Aluno(a): Miguel Sanches Braga Inácio
               Profa. Michelle Nery Nascimento*/

            /*01. Faça um programa que leia os elementos de uma matriz 3 x 5 com números inteiros, calcule e
               imprima a quantidade de elementos maiores que 40.*/
            /*
            int[,] mat = new int[3, 5];
            Random rd = new Random();
            int contador = 0;

            for(int i = 0; i < mat.GetLength(0); i++)
            {
                for(int j = 0; j < mat.GetLength(1); j++)
                {
                    mat[i, j] = rd.Next(1, 101);
                    if (mat[i,j] > 40)
                    {
                        contador++;
                    }
                    Console.Write(" " + mat[i, j]);
                }
                Console.WriteLine();
               
            }
           
            Console.WriteLine("\n A quantidade de elementos maiores que 40 é: " + contador);*/

            /*02. Faça um programa que:
            a) leia uma matriz quadrada de 10 x 10 elementos inteiros
            b) imprima essa matriz
            c) calcule e imprima a soma dos elementos situados na diagonal secundária e abaixo dela.*/
            /*
            int[,] mat = new int[10,10];
            Random rd = new Random();
            int somadS = 0,somaba=0,somat;

            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    mat[i, j] = rd.Next(1, 101);
                   
                    Console.Write(mat[i, j]+" ");
                    if (j == mat.GetLength(1) - i - 1)
                    {
                            somadS += mat[i, j];
                    }
                    if(j >= mat.GetLength(1) - i)
                    {
                        somaba += mat[i, j];
                    }
                   
                }
                Console.WriteLine();
            }
            somat = somadS + somaba;
            Console.WriteLine("\n Soma: " + somat);*/
            /*3. Faça um programa que:
            a) leia uma matriz quadrada de 20 x 20 elementos reais
            b) divida cada elemento de uma linha da matriz pelo elemento da diagonal principal desta linha
            c) imprima a matriz assim modificada*/
            /*
            int[,] mat = new int[20,20];
            int[,] mod = new int[20,20];
            Random rd = new Random();

            Console.WriteLine("Matriz normal:");
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    mat[i,j] = rd.Next(10,101);
                    
                    Console.Write(mat[i,j]+" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n");
            Console.WriteLine("Diagonal principal:");
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                Console.Write(mat[i, i] + " ");
                
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    mod[i,j] = mat[i, i] / mat[i,j];
                }
            }
            

            // Impressão da matriz modificada
            Console.WriteLine("\nMatriz modificada:");
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    mod[i, j] = mat[i, i] / mat[i, j];
                    Console.Write(mod[i, j] + " ");
                }
                Console.WriteLine();
            }
            */

            /*4. Elabore um programa que leia uma matriz 4 x 4 e indique se é uma matriz triangular superior.
            Matriz triangular superior é uma matriz quadrada onde todos os elementos abaixo da diagonal
            principal são nulos(valor zero).Veja exemplo abaixo:
             5 4 99 8
             0 7 13 0
             0 0 1  6
             0 0 0  2 */
            /*
            int[,] mat = { {1,1,1,1 }, { 0, 1, 1, 1 }, {0,0,1,1 }, {0,0,0,1} };
            
            bool triangular = true;

            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    Console.Write(mat[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n");
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    if (i > j)
                    {
                        if (mat[i,j] !=0)
                        {
                         triangular = false;   
                        }
                   }
                } 
            }

            if(triangular)
            {
                Console.WriteLine("É uma matriz triangular superior");
            }
            else
            {
                Console.WriteLine("Não é uma matriz triangular superior");
            }*/
            /*5. Faça um programa que leia os elementos de uma matriz 5 x 5 e crie dois vetores de cinco
            posições cada um, que contenham, respectivamente, as somas das linhas e das colunas da
            matriz.Escreva a matriz e os vetores criados*/
            /*
            int[,] mat = new int[5,5];
            int[] veta = new int[5];
            int[] vetb = new int[5];
            Random rd = new Random();
            Console.WriteLine("Matriz:");
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    mat[i, j] = rd.Next(10, 21);

                    Console.Write(mat[i, j] + " ");
                    

                }
                Console.WriteLine();
            }

            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    veta[i] += mat[i, j];
                    vetb[j] += mat[i, j];
                }
               
            }
            Console.WriteLine("\nSomas das linhas:");
            for (int i = 0; i < veta.Length; i++)
            {
                Console.Write(veta[i] + " ");
            }

            Console.WriteLine("\n\nSomas das colunas:");
            for (int i = 0; i < vetb.Length; i++)
            {
                Console.Write(vetb[i] + " ");
            }
            */
            /*6. Escreva um programa que preencha uma matriz 5 x 5 com números aleatórios de 1 a 50.Depois
            mostre a matriz gerada, encontre e mostre todos os números primos e a posição onde cada
            um deles se encontra no formato:
            O número X é primo e se encontra no índice: [linha – coluna].*/
            /*
            int[,] mat = new int[5,5];
            Random rd = new Random();
            
            Console.WriteLine("Matriz:");
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    mat[i, j] = rd.Next(1, 51);

                    Console.Write(mat[i, j] + " ");


                }
                Console.WriteLine();
            }

            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    bool primo = true;
                    for (int k = 2; k <= Math.Sqrt(mat[i,j]); k++)
                    {
                        if (mat[i, j] % k == 0)
                        {
                            primo = false;
                        }
                    }
                    if (primo && mat[i,j] !=1)
                    {
                        Console.WriteLine("O número: " + mat[i, j] + " é primo e se encontra no índice ["+ i + " - " + j+"]");
                    }
                }  
            }*/

            /*7. Escrever um programa que determine se uma matriz quadrada de n > 0 linhas e colunas é uma
            matriz de permutação. Uma matriz quadrada é chamada de matriz de permutação se seus 2 elementos 
            são apenas 0’s e 1’s e se em cada linha e coluna da matriz existe apenas um único valor 1.
            Para testar o exercício, considere a matriz 4X4 do exemplo.*/
            /*
            int[,] mat = new int[4,4];
            Random rd = new Random();
            bool permuta = true;
            Console.WriteLine("Matriz:");
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    mat[i, j] = rd.Next(0, 2);
                    Console.Write(mat[i, j] + " ");
                }

                Console.WriteLine();
                
            }

            for (int i = 0; i < mat.GetLength(0); i++)
            {
                int linha = 0;
                int coluna = 0;
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    linha += mat[i, j];
                    coluna += mat[j, i];
                }
                if (linha != 1 || coluna != 1)
                {
                    permuta = false;
                }
            }

            if (permuta)
            {
                Console.WriteLine("É uma matriz de permutação");
            }
            else
            {
                Console.WriteLine("Não é uma matriz de permutação");
            }
           */

        }
    }
}