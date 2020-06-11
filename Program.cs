using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Abtraction.abtractionClass;
using Abtraction.Interface;

namespace Abtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("The Concept of Abstraction Using Abstract Class. ");
            Console.WriteLine();
            tumbuhan Tumbuhan;

            Tumbuhan = new Monokotil();
            Tumbuhan.jenisBiji();

            Tumbuhan = new Dikotil();
            Tumbuhan.jenisBiji();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("The Concept of Abstraction Using an Interface. ");
            Console.WriteLine();
            IReproduksi reproduksiTumbuhan;

            reproduksiTumbuhan = new Generatif();
            reproduksiTumbuhan.BerkembangBiak();

            reproduksiTumbuhan = new Vegetatif();
            reproduksiTumbuhan.BerkembangBiak();

            Console.ReadKey();
        }
    }
}