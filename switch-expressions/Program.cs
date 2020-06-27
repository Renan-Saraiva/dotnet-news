using System;

namespace switch_expressions
{
    public enum Rainbow
    {
        Red,
        Orange,
        Yellow,
        Green,
        Blue,
        Indigo,
        Violet
    }

    public enum Days
    {
        Friday,
        Monday,
        Sunday
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(GetDayString(Days.Friday));
            Console.WriteLine(GetDayString(Days.Sunday));
        }

        public static string FromRainbow(Rainbow colorBand) =>
            colorBand switch
            {
                Rainbow.Red => "Red",
                Rainbow.Orange => "Orange",
                Rainbow.Yellow => "Yellow",
                Rainbow.Green => "Green",
                Rainbow.Blue => "Blue",
                Rainbow.Indigo => "Indigo",
                Rainbow.Violet => "Violet",
                _ => throw new ArgumentException(message: "invalid enum value", paramName: nameof(colorBand)),
            };


        /// <summary>
        /// É possível utilizar a expressão abaixo para avaliar as diferentes opções de um switch, o opção "_" representa a opção "Default"
        /// </summary>
        /// <param name="day"></param>
        /// <returns></returns>
        public static string GetDayString(Days day) =>
            day switch
            {
                Days.Friday => "Friday", _ => "Desconhecido"
            };


        public static string GetDayStringWithBrackets(Days day)
        {
            return day switch
            {
                Days.Friday => "Friday",
                _ => "Desconhecido"
            };
        }
    }
}
