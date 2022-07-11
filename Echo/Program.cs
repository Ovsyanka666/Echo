using System;

class MainClass
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Напишите что-то");
        //var str = Console.ReadLine();

        //Console.WriteLine("Укажите глубину эха");
        //var deep = int.Parse(Console.ReadLine());

        //Echo(str, deep);

        //Console.ReadKey();

        //Console.WriteLine(Factorial(20));

        Console.WriteLine(PowerUp(5, 2));
    }

    static void Echo(string phrase, int deep)
    {
        int deepdeep = deep % 10;
        Console.BackgroundColor = (ConsoleColor)deepdeep;

        var modif = phrase;
        if (modif.Length > 2)
        {
            modif = modif.Remove(0, 2);
        }
        Console.WriteLine("..." + phrase);

        if (deep > 1)
        {
            Echo(modif, deep - 1);
        }
    }

    static long Factorial(long x)
    {
        if (x == 0)
        {
            return 1;
        }
        else
        {
            return x * Factorial(x - 1);
        }
    }

    private static int PowerUp(int N, int pow)
    {
        if (pow == 0)
            return 1;
        else if (pow == 1)
            return N;
        else
            return N * PowerUp(N, --pow);
    }
}