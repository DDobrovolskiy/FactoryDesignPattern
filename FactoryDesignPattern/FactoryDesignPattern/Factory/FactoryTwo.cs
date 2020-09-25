using System;
using System.Collections.Generic;
using System.Text;
using FactoryDesignPattern.Factory.Parts;

namespace FactoryDesignPattern.Factory
{
    public class FactoryTwo : FactoryBase, IFactory
    {
        public FactoryTwo()
        {
            _parts = new PartsFirst();
        }
    }
}
