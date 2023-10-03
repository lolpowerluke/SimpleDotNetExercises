// See https://aka.ms/new-console-template for more information
using ConsoleApp1;

//Condities_en_iteraties.main();


/* ------------------- Werken_met_arrays ------------------- */
/* 
string[] createdArray = Werken_met_arrays.createArray();
Console.WriteLine("Array: ");
for (int i = 0; i < createdArray.Length; i++)
{
    Console.WriteLine((i+1) + ": " + createdArray[i]);
}
*/


/* ------------------- Gebruik_nullables ------------------- */
/*
Gebruik_nullables.calculateBonus();
*/


/* --------------- Oefening_op_Eigenschappen --------------- */
/*
Console.WriteLine("Write a sentence.");
string input = Console.ReadLine();
Console.WriteLine(Oefening_op_Eigenschappen.getNumber(input));
*/


/* ----------- Oefening_op_Generieke_Collecties ------------ */
/*
Oefening_op_Generieke_Collecties<int> rij = new Oefening_op_Generieke_Collecties<int>();
char keuze = '0';
int even;
do
{
    Console.WriteLine("Kies achtereenvolgens:");
    Console.WriteLine(" 0  Stoppen");
    Console.WriteLine(" 1  Toevoegen");
    Console.WriteLine(" 2  Verwijderen");
    Console.WriteLine(" 3  Toon hele rij");
    Console.WriteLine(" 4  Maak de rij leeg");
    Console.Write("Geef je keuze en druk [enter]: ");
    keuze = Console.ReadLine()[0];
    Console.WriteLine();

    switch (keuze)
    {
        case '0':
            break;
        case '1':
            Console.Write("Geef het toe te voegen getal: ");
            rij.Opzetten(Convert.ToInt32(Console.ReadLine()));
            break;
        case '2':
            even = rij.Afhalen();
            if (even == int.MinValue)
                Console.WriteLine("De rij is leeg");
            else
                Console.WriteLine("Het eerste getal in de rij was " + even);
            Console.WriteLine();
            break;
        case '3':
            Console.WriteLine("De hele rij is:");
            Console.Write(rij.ToString());
            Console.WriteLine();
            break;
        case '4':
            rij.Leegmaken();
            break;
        default:
            Console.WriteLine("???");
            break;
    }
} while (keuze != '0');
*/