using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryDesignPattern.Factory.Parts
{
    public class PartsFirst : IParts
    {
        public string GetParts() => "Parts first create";
    }
}
