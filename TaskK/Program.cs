using System;

namespace TaskK
{
    class Program
    {
        static void Main(string[] args)
        {
            Celsius celsius = new Celsius(100);
            Kelvin kelvin = celsius;
            Console.WriteLine(kelvin.Degree);
            
        }
    }
}
