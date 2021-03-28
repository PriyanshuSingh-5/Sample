using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Program program = new Program();
            double res = program.TestMethod();
            Console.WriteLine("double value in main method" + res);


            Console.Read();
        }Console.WriteLine("priyanshu");
        public double TestMethod()
        {
            double result = 2.3 + 4.5;
            Console.WriteLine("double value in main method" + res);
            return result;
        }
    }
}
