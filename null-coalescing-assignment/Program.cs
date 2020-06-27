using System;
using System.Collections.Generic;

namespace null_coalescing_assignment
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int?> numeros = null;

            numeros ??= new List<int?>();

            int? numero = null;
            numero ??= 10;
            numeros.Add(numero);
            numero ??= 11;
            numeros.Add(numero);

            //Testes para entender IEnumerable
            foreach (var itemDoBanco in BuscaIds(new List<int> { 10, 20, 30}))
            {
                Console.WriteLine(itemDoBanco);
            }
        }

        public static System.Collections.Generic.IEnumerable<int> BuscaIds(List<int> ids)
        {
            foreach (var id in ids)
            {
                //BuscaAlgoNoBanco
                yield return id;
            }
        }
    }
}
