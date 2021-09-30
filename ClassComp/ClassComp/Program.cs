using System;

namespace ClassComp
{
    class Program
    {
        static void Main(string[] args)
        {
            Parameters parameters = new Parameters("Intel Core i7 1165G7", "Nvidia GeForce MX450", "8GB", "512 GB SSD", "1920 x 1080", "Jedel GM680", "Logitech gaming G915", "JBL Quantum Duo");
            //Console.WriteLine("Parameters:");
            //Console.WriteLine(parameters.GetFullParam());

           Notebook notebook = new Notebook("HP", "Pavilion 15-ug008");
            Console.WriteLine("Notebook:");
            Console.WriteLine($"{notebook.NotebookParams()} {parameters.GetParams()}".Trim());

           PC pc = new PC("Dell 240 Hz Gaming S2522HG");
           //Console.WriteLine("PC:");
           //Console.WriteLine($"{pc.PcParams()} {parameters.GetFullParam()}".Trim()); 
        }
    }
}
