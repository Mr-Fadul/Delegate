using System;
using System.Collections.Generic;
using System.Text;

namespace Delegate
{
    class Calculadora
    {



        //metodos estaticos? motodo sem objeto para ser usado
        // pode chamar o metodo sem estanciar a classe no main
        public static int somar(int x, int y)
        {
            return x + y;
        }
        public static int subtrair(int x, int y)
        {
            return x - y;
        }
        public static int multiplicar(int x, int y)
        {
            return x * y;
        }
        public static int dividir(int x, int y)
        {
            return x / y;
        }
        public static int fatorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            return n * fatorial(n - 1); // recursivo - quando um metodo chama ele mesmo, cria um loop sem usar for ou while, cuidado com o stack overflow
        }
        //public static int fatorial2(int n)
        //{
        //    if (n == 0)
        //    {
        //        return 1;
        //    }

        //    return fat;
        //}
    }
}
