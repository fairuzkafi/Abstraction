using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Abtraction.Interface
{
    public class Vegetatif : IReproduksi
    {
        public void BerkembangBiak()
        {
            Console.WriteLine("Vegetative is a breeding done by plants without fusion between two gamete cells from male and female");
        }
    }
}