using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderDesignPattern
{
    public class Laptop
    {
        public string Processor { get; set; }
        public int RAM { get; set; }

        public void ShowDetails()
        {
            Console.WriteLine($"Processor: {Processor}");
            Console.WriteLine($"RAM: {RAM} GB");
        }
    }
}
