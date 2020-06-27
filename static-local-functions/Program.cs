using System;

namespace static_local_functions
{
    class Program
    {
        static void Main(string[] args)
        {
            int valConst = 10;
            int valor1 = 5;
            int valor2 = 5;

            Pessoa pessoa = new Pessoa(10, Sexo.Feminino);
          
            Console.WriteLine(LocalSoma(valor1, valor2));
            
            int LocalSoma(int valor1, int valor2) => (valor1 + valor2) * valConst;

            //Funções local definidas como static não tem acesso ao escopo que a engloba 
            //static int StaticLocalSoma(int valor1, int valor2) => (valor1 + valor2) * valConst;
        }
    }

    public class Pessoa
    {
        public int Idade { get; set; }
        public Sexo Sexo { get; set; }

        public Pessoa(int idade, Sexo sexo) => (Idade, Sexo) = (idade, sexo);

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
