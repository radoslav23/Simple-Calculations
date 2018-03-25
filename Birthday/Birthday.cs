using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Birthday
{
    class Birthday
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());

            int size = length * width * height;
            double litresAmount = size * 0.001;
           // Console.WriteLine(litresAmount);

            double percentCalculation = percent * 0.01;
           // Console.WriteLine(percentCalculation);

            double reallitresAmount = (litresAmount * (1 - percentCalculation));

            Console.WriteLine("{0:f3}",(reallitresAmount));
        }
    }
}
