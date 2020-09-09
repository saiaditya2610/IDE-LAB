using System;

namespace first
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Time is"+ DateTime.Now);
int a=10;
int b=20;
int c=a+b;
Console.WriteLine(c);
OrderPrecedence();
        }
        static void OrderPrecedence()
{
int a = 5;
            int b = 4;
            int c = 2;
            int d = a + b * c;
            Console.WriteLine(d);

            d = (a + b) * c;
            Console.WriteLine(d);


}

    }
}
