using System;

namespace default_interface_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            IAnimal animal = new Cachorro();

            animal.Brincar();
            animal.Comer(new RacaoCachorro());
        }
    }

    public interface IAnimal
    {
        void Brincar();

        /// <summary>
        /// Podemos implementar comportamentos em Interfaces a partir do C# 8 (.Net Standart 2.1+ e .Net Core 3.1+)
        /// </summary>
        /// <param name="food"></param>
        public void Comer(IComida food)
        {
            Console.WriteLine("Animal comendo");
        }
    }

    public interface IComida { }

    public class RacaoCachorro : IComida { }

    public class Cachorro : IAnimal
    {
        public void Brincar()
        {
            Console.WriteLine("Cachorro brincando");
        }
    }
}
