/*Desafio

Faça a leitura de um valor inteiro. Em seguida, calcule o menor número de notas possíveis (cédulas)
onde o valor pode ser decomposto. As notas que você deve considerar são de 100, 50, 20, 10, 5, 2 e 1. 
Na sequência mostre o valor lido e a relação de notas necessárias.

Entrada

Você receberá um valor inteiro N (0 < N < 1000000).

Saída

Exiba o valor lido e a quantidade mínima de notas de cada tipo necessárias, seguindo o exemplo de saída
abaixo. Após cada linha deve ser imprimido o fim de linha.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace URI_1018
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int N, nota100, nota50, nota20, nota10, nota5, nota2, nota1, resto;

            N = int.Parse(Console.ReadLine());

            nota100 = N / 100;
            resto = N % 100;

            nota50 = resto / 50;
            resto = resto % 50;

            nota20 = resto / 20;
            resto = resto % 20;

            nota10 = resto / 10;
            resto = resto % 10;

            nota5 = resto / 5;
            resto = resto % 5;

            nota2 = resto / 2;
            resto = resto % 2;

            nota1 = resto / 1;
            resto = resto % 1;

            Console.WriteLine(N);
            Console.WriteLine(nota100 + " nota(s) de R$ 100,00");
            Console.WriteLine(nota50 + " nota(s) de R$ 50,00");
            Console.WriteLine(nota20 + " nota(s) de R$ 20,00");
            Console.WriteLine(nota10 + " nota(s) de R$ 10,00");
            Console.WriteLine(nota5 + " nota(s) de R$ 5,00");
            Console.WriteLine(nota2 + " nota(s) de R$ 2,00");
            Console.WriteLine(nota1 + " nota(s) de R$ 1,00");
        }
    }
}
