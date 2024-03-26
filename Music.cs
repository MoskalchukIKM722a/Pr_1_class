using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Pr_1_class
{
    public class Music
    {
        private string name;
        private string author;
        private int year;
        private int sings;
        private double copys;
 
        public Music(string name, string author, int year, int sings, double copys)
       {
        this.name = name;
        this.author = author;
        this.year = year;
        this.sings = sings;
        this.copys = copys;
       }

        public void DisplayInfo()
        {
            Console.WriteLine($"Album '{name}'");
            Console.WriteLine($"Author '{author}'");
            Console.WriteLine($"Year - {year}");
            Console.WriteLine($"Sings: {sings}");
            Console.WriteLine($"Copies: {copys}");
        }
        public void UpdateCopys(double copys)
        {
            this.copys = copys;
            Console.WriteLine(" Copies was saled");
        }

        public bool NeedMore()
        {
            return copys > 300; 
        }
        public void EndSales()
        {
            copys = 0;
            Console.WriteLine("sales was end");
        }
    }

   
}
