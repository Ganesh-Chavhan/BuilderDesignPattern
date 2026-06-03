using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderDesignPattern
{
    public class LaptopBuilder
    {
        private Laptop laptop = new Laptop();

        public LaptopBuilder SetProcessor(string processor)
        {
            laptop.Processor = processor;
            return this;
        }

        public LaptopBuilder SetRAM(int ram)
        {
            laptop.RAM = ram;
            return this;
        }

        public Laptop Build()
        {
            return laptop;
        }
    }
}
