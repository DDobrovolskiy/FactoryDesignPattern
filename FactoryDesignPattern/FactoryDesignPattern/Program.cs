using System;
using FactoryDesignPattern.Factory;
using FactoryDesignPattern.Factory.Parts;

namespace FactoryDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Factory Design Pattern!");
            Console.WriteLine("---");

            IFactory factory = new FactoryFirst(new PartsTwo());
            factory.GetSolution();

            Console.WriteLine("---");

            factory = new FactoryTwo();
            factory.GetSolution();

            Console.WriteLine("---");

            Console.ReadKey();
        }
    }
}
