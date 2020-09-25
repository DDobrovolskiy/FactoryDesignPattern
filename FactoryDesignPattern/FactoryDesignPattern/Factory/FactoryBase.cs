using System;
using System.Collections.Generic;
using System.Text;
using FactoryDesignPattern.Factory.Parts;

namespace FactoryDesignPattern.Factory
{
    public abstract class FactoryBase : IFactory
    {
        protected IParts _parts;

        public void GetSolution()
        {
            Console.WriteLine("Factory assembler: " + _parts.GetParts());
        }
    }
}
