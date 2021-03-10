using System;

namespace example1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a =0, b =0;
            Console.WriteLine("enter a value for a: ");
            a=Int32.Parse(Console.ReadLine());
            
            Console.WriteLine("enter a value for b: ");
            
            Console.WriteLine($"Adding {a} + {b} equals {addnumbers(a,b)} ");  
        }
        static int addnumbers(int a, int b)
        {
            return a-b;
        }
    }
}
