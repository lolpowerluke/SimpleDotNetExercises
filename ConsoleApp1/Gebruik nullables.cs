using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Gebruik_nullables
    {
        public static void calculateBonus()
        {
            Console.WriteLine("Naam: ");
            string name = Console.ReadLine();
            bool isValid = false;
            float verkoopJaren;
            do
            {
                Console.WriteLine("Hoe lang heeft hij bij Verkoop gewerkt?");
                string input = Console.ReadLine();
                isValid = float.TryParse(input, out verkoopJaren);
            } while (isValid == false);
            float ondersteuningJaren;
            isValid = false;
            do
            {
                Console.WriteLine("Hoe lang heeft hij bij Ondersteuning gewerkt?");
                string input = Console.ReadLine();
                isValid = float.TryParse(input, out ondersteuningJaren);
            } while (isValid == false);
            float administratieJaren;
            isValid = false;
            do
            {
                Console.WriteLine("Hoe lang heeft hij bij Administratie gewerkt?");
                string input = Console.ReadLine();
                isValid = float.TryParse(input, out administratieJaren);
            } while (isValid == false);
            int bonus;
            if ((verkoopJaren < 1 && ondersteuningJaren < 1) || (verkoopJaren < 1 && administratieJaren < 1) || (ondersteuningJaren < 1 && administratieJaren < 1))
            {
                bonus = 0;
            }
            else
            {
                double bonusFloat = Math.Floor(verkoopJaren) + Math.Floor(ondersteuningJaren) + Math.Floor(administratieJaren);
                bonus = Convert.ToInt32(bonusFloat);
            }

            Console.WriteLine(name + " krijgt " + bonus + "% bonus wedde");
        }
    }
}
