using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Werken_met_arrays
    {
        public static string[] createArray()
        {
            bool isValid = false;
            int lenght;
            do
            {
                Console.WriteLine("How long should the array be?");
                string input = Console.ReadLine();
                isValid = int.TryParse(input, out lenght);

            } while(isValid == false);
            string[] array = new string[lenght];
            for(int i = 0; i < lenght; i++)
            {
                Console.WriteLine("Give element " + (i+1));
                array[i] = Console.ReadLine();
            }
            return array;
        }
    }
}
