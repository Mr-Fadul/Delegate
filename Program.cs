using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
namespace Delegate
{
    class Program
    {
        static void Main(string[] args)
        {
            //// seta lambda é uma função anonima, tira a nescecidade de chaves e return se tiver apenas uma linha.
            //MeuDelegate delegate1 = (x, y) => x + y;

            ////receber apenas 1 parâmetro n é necessário colocar parenteses  
            //MeuoutroDelegate delegate2 = n => n * 2;

            //Console.WriteLine(delegate1(4, 5));
            //Console.WriteLine(delegate2(5));
            //// func um delegate q pode receber 17 argumentos 
            //Func<int, int, int> soma = (x, y) => x + y;

            List<int> numeros = new List<int>() {20, 10, 4, 7, 12, 34, 23 };



            //List<int> numerosPares = numeros.FindAll(n => n % 2 == 0).ToList();
            //List<int> numerosImpares = numeros.FindAll(n => n % 2 != 0).ToList();

            //numerosPares.ForEach(Console.WriteLine);
            //numerosImpares.ForEach(Console.WriteLine);


            //foreach (int n in numeros)
            //{
            //    if (n % 2 == 0)
            //    {
            //        numerosPares.Add(n);
            //    }
            //    else
            //    {
            //        numerosImpares.Add(n);
            //    }
            //}

            //Console.WriteLine("Pares:");

            //foreach (int n in numerosPares)
            //{
            //    Console.WriteLine(n);
            //}
            //Console.WriteLine("Impares:");
            //foreach (int n in numerosImpares)
            //{
            //    Console.WriteLine(n);
            //}

            //numeros.FindAll(n => n % 2 == 0).ForEach(Console.WriteLine);

            //List<string> nomes = new List<string>() { "Fulano", "ciclano", "Beltrano" };
            //nomes.FindAll(nome => nome == "fulano").ForEach(Console.WriteLine);

            // numeros.Select(n => n * n).ToList().ForEach(Console.WriteLine);

            //nomes.Select(nome => nome.Length).ToList().ForEach(Console.WriteLine);

            //nomes.Select(nome => nome.ToString()).ToList().ForEach(Console.WriteLine);

            //numeros.FindAll(n => n > 10).Select(n => n * n).ToList().ForEach(Console.WriteLine);


            //Console.WriteLine("Informe um numero para pesquisar : ");

            //int numeroPesquisa = int.Parse(Console.ReadLine());
            //int resultado = numeros.Find(n => n == numeroPesquisa);

            //Console.WriteLine("retorno da busca : " + resultado);

            numeros.Sort((n1, n2) => n1 - n2);
            numeros.ForEach(Console.WriteLine);
            
         


        }
    }
}
