//Desenvolva um programa capaz de ler três valores e apresentar o maior deles e adicionar a mensagem “ eh o maior”. Use a seguinte forma como base:

//MaiorAB = (a+b+abs(a-b))/2

//Obs.: a fórmula apenas calcula o maior entre os dois primeiros (a e b). Um segundo passo, portanto é necessário para chegar no resultado esperado.

//Entrada
//O arquivo de entrada contém três valores inteiros.

//Saída
//Imprima o maior dos três valores seguido pela mensagem " eh o maior".

using System;

namespace OMaior
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split(' ');
            //complete declarando as variáveis

            int a = Int32.Parse(vet[0]);
            int b = Int32.Parse(vet[1]);
            int c = Int32.Parse(vet[2]);

            int MAIORAB = (a + b + Math.Abs(a - b)) / 2;

            int MAIOR = (MAIORAB + c + Math.Abs(MAIORAB - c)) / 2;

            Console.WriteLine($"{MAIOR} eh o maior");
        }
    }
}
