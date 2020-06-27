using System;

namespace tuple_patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(VerificaValores(1,2));
            Console.WriteLine(VerificaValores(2,1));
            Console.WriteLine(VerificaValores(2, 10));
            Console.WriteLine(VerificaValores(300, 8000));
        }

        /// <summary>
        /// Podemos avaliar em uma expressão switch dois valores com o Tuple Patterns, 
        /// </summary>
        /// <param name="numero1"></param>
        /// <param name="numero2"></param>
        /// <returns></returns>
        public static string VerificaValores(int numero1, int numero2) =>
            (numero1, numero2) switch
            {
                (1, 2) => "Numero1 é 1, Numero2 é 2",
                (2, 1) => "Numero1 é 2, Numero2 é 1",
                (_, 10) => "Só sei que o número 2 é 10",
                (_, _) => "Qualquer outra cambinção"
                //_ => "Qualquer outra cambinção" tbm é possível usar um único _
            };
    }
}
