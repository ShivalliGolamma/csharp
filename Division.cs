using System;

namespace freshers
{
    class Division
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 50;
            int c = b/a;
            Console.WriteLine("Value of c is:"+c);

            Console.WriteLine("value of a before applying increment operators:"+a);

            ++a;
            Console.WriteLine("Value of a after preincrement is:"+a);

            a++;
            Console.WriteLine("Value of a after postincrement is:"+a);

            Console.WriteLine("value of a before applying decrement operators:"+a);

            --a;
            Console.WriteLine("Value of c after predecrement is:"+a);

            a--;
            Console.WriteLine("Value of c after postdecrement is:"+a);

        }
    }
}