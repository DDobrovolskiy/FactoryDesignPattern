using FactoryDesignPattern.Factory.Parts;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryDesignPattern.Factory
{
    public class FactoryFirst : FactoryBase, IFactory
    {
        public FactoryFirst(IParts parts)
        {
            _parts = parts;
        }
    }
}
