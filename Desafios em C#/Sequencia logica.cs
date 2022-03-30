/*Desafio

Desenvolva um programa capaz de ler um valor inteiro N. N * 2 linhas de saída vão ser 
apresentadas na execução do programa, seguindo a lógica do exemplo mais abaixo. Para os
valores com mais de seis dígitos, todos os dígitos devem ser apresentados.

Entrada
O arquivo de entrada contém um número inteiro positivo N (1 < N < 1000).

Saída
Imprima a saída conforme o exemplo fornecido.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI_1144
{
    class Program
    {
        static void Main(string[] args)
        {
 int m1, m2;
            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                m1 = (int)Math.Pow(i, 2);
                m2 = m1 * i;
                Console.Write(i + " ");
                Console.Write(m1 + " ");
                Console.WriteLine(m2);
                Console.Write(i + " ");
                m1++;
                m2++;
                Console.Write(m1 + " ");
                Console.WriteLine(m2);
            }
        }
    }
}
