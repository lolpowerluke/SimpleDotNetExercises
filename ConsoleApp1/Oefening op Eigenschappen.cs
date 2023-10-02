using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Oefening_op_Eigenschappen
    {
        public static string getNumber(string input)
        {
            string a = string.Empty;
            int val;

            for (int i = 0; i < input.Length; i++)
            {
                if (Char.IsDigit(input[i]))
                    a += input[i];
            }
            return a;
        }
    }
}
