using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string Str;

            while ((Str = Console.ReadLine()) != null)
            {

                Str = Str.Replace(",", " y:");
                Str = "x:" + Str;

                Console.WriteLine(Str);
            }

        }
    }
}