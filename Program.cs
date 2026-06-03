namespace BuilderDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Laptop laptop = new LaptopBuilder()
                            .SetProcessor("Intel i5")
                            .SetRAM(8)
                            .Build();

            laptop.ShowDetails();
        }
    }
}
