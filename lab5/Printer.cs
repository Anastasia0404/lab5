using System;

namespace lab5
{
    class Printer
    {
        public virtual void Print(string value)
        {
            Console.WriteLine(value);
        }
    }
    class PrinterRed : Printer
    {
        public override void Print(string value)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            base.Print(value);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var printers = new Printer[2];
            printers[0] = new Printer();
            printers[1] = new PrinterRed();
            printers[0].Print("It is Printer!");
            printers[1].Print("It is PrinterRed!");
            Console.ReadKey();
        }
    }
}