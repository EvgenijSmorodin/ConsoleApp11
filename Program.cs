using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int progression = 7;
            int minNumber = 5;
            for (int i = 96; i>=minNumber; i-=progression ) 
            {
                Console.WriteLine(i);
            }
        }
    }
}
