using System;

namespace ready_only
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public struct Point
    {
        public double X { get; set; }
        public double Y { get; set; }
        public readonly double Distance => Math.Sqrt(X * X + Y * Y);

        public readonly override string ToString() => $"({X}, {Y}) is {Distance} from the origin";

        /// <summary>
        /// Caso o método seja readyonly o compilador garante que nenhuma propriedade do objeto que o método está definido seja alterado
        /// </summary>
        /// <param name="xOffset"></param>
        /// <param name="yOffset"></param>
        public readonly void Translate(int xOffset, int yOffset, Point point)
        {
            //Consegue alterar a propriedade de outras instancias, mas da propia não
            point.X = xOffset;
            point.Y = yOffset;

            X += xOffset;
            Y += yOffset;
        }
    }
}
