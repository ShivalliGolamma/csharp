using System;

namespace freshers
{
    /*New class created for doing addition,increment and decrement operations
    Created By Golamma Shivalli on 3rd feb 2021*/
    class Addition
    {
        static void Main(string[] args)
        {
            int a=10; //first variable declared and initialized
            int b=50;
            int c= a+b; //adding 2 variable values and storing it in variable c
            Console.WriteLine("Value of c is:"+c);//printing a value

            Console.WriteLine("Value of c is:"+c);

            Console.WriteLine("value of a before applying increment operators:"+a);

            ++a; //applying preincrement operator for one variable
            Console.WriteLine("Value of a after preincrement is:"+a);

            a++; //applying postincrement operator for one variable
            Console.WriteLine("Value of a after postincrement is:"+a);

            Console.WriteLine("value of a before applying decrement operators:"+a);

            --a; //applying predecrement operator for one variable
            Console.WriteLine("Value of c after predecrement is:"+a);

            a--; //applying predecrement operator for one variable
            Console.WriteLine("Value of c after postdecrement is:"+a);

        }
    }
}
