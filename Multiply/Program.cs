using System;

namespace Multiply {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Multiply");
            var sum = 1;
            for (var index = 1; index<11; index++) {
                sum = sum*index;
                //Console.WriteLine(index);
                }
            Console.WriteLine($"Sum is {sum}");//interpolation way to build strings
            Console.WriteLine(sum);


            //alternate solution
            var product = 1;
            var nbr = 1;
            while (nbr <= 10) {
                product *= nbr;
                nbr++;
                }
            Console.WriteLine($"Product is {product}");
            }
        }
    }
