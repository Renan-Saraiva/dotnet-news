using System;

namespace property_patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Cidade cidade = new Cidade { Nome = "Guarulhos", UF = "SP" };
            Console.WriteLine(GetGMT(cidade));
        }

        /// <summary>
        /// Podemos avaliar a propriedade de um método no Switch utilizando o property-patterns
        /// </summary>
        /// <param name="cidade"></param>
        /// <returns></returns>
        public static int GetGMT(Cidade cidade)
        {
            return cidade switch
            {
                { UF: "AC" } => -5,
                { UF: "AM" } => -5,
                { UF: "RR" } => -4,
                { UF: "RO" } => -4,
                { UF: "PA" } => -4,
                { UF: "MT" } => -4,
                { UF: "MS" } => -4,
                _ => -3
            };
        }
    }

    public class Cidade
    {
        public string Nome { get; set; }
        public string UF { get; set; }
    }
}
