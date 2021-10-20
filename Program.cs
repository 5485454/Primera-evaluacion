using System;

namespace primer_proyecto
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 9;
            int b = 5;
            int c = 3;

            //abc
            Console.Write(a);
            Console.Write(b);
            Console.WriteLine(c);

            Console.WriteLine($"la combinacion de las variables abc: {a}{b}{c}");

            //aacb
            Console.Write(a);
            Console.Write(a);
            Console.Write(c);
            Console.WriteLine(b);

            Console.WriteLine($"la combinacion de las variables aacb: {a}{a}{c}{b}");

             //bca
            Console.Write(b);
            Console.Write(c);
            Console.WriteLine(a);

            Console.WriteLine($"la combinacion de las variables bca: {b}{c}{a}");

            //bcbc
            Console.Write(b);
            Console.Write(c);
            Console.Write(b);
            Console.WriteLine(c);

            Console.WriteLine($"la combinacion de las variables aacb: {b}{c}{b}{c}");

 
            Console.WriteLine("pongame 20 profe andele :'(");
        }
    }
}
