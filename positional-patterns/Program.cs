using System;

namespace positional_patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Pessoa pessoa = new Pessoa { Idade = 18, Sexo = Sexo.Masculino };
            Pessoa pessoa2 = new Pessoa { Idade = 17, Sexo = Sexo.Masculino };
            Pessoa pessoa3 = new Pessoa { Idade = 18, Sexo = Sexo.Feminino };
            Pessoa pessoa4 = new Pessoa { Idade = 15, Sexo = Sexo.Feminino };

            Console.WriteLine(GetAlistamentoMSG(pessoa));
            Console.WriteLine(GetAlistamentoMSG(pessoa2));
            Console.WriteLine(GetAlistamentoMSG(pessoa3));
            Console.WriteLine(GetAlistamentoMSG(pessoa4));
        }

        /// <summary>
        /// Com a implementação do Deconstruct, podemos descontruir o nome objeto, e aplicar condicionais no Switch
        /// </summary>
        /// <param name="pessoa"></param>
        /// <returns></returns>
        static string GetAlistamentoMSG(Pessoa pessoa) => pessoa switch
        {
            var (idade, _) when idade < 18 => "Ainda não pode se alistar",
            var (idade, sexo) when idade >= 18 && sexo == Sexo.Masculino => "Precisa se alistar",
            var (idade, sexo) when idade >= 18 && sexo == Sexo.Feminino => "Alistamento é opcional",
            _ => "Desconhecido"
        };
    }

    public class Pessoa 
    {
        public int Idade { get; set; }
        public Sexo Sexo { get; set; }

        /// <summary>
        /// Caso o objeto tenha o método Deconstruct a funcionalidade de Positional Patterns pode ser utilizada
        /// </summary>
        /// <param name="idade"></param>
        /// <param name="sexo"></param>
        public void Deconstruct(out int idade, out Sexo sexo) => (idade, sexo) = (Idade, Sexo);
    }

    public enum Sexo
    {
        Feminino,
        Masculino
    }
}
