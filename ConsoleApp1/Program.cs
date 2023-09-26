// See https://aka.ms/new-console-template for more information
Console.WriteLine("give word!");
string word = Console.ReadLine();
char[] charArray1 = word.ToCharArray();
Array.Reverse(charArray1);

Console.WriteLine("For");
for(int i = 0; i < charArray1.Length; i++)
{
    Console.Write(charArray1[i]);
}
Console.WriteLine();
Console.WriteLine("Do while");
int j = 0;
do
{
    Console.Write(charArray1[j]);
    j++;
    
} while(j < charArray1.Length);

Console.WriteLine();
Console.WriteLine("While");
int k = 0;
while (k < charArray1.Length)
{
    Console.Write(charArray1[k]);
    k++;

}
Console.WriteLine();
Console.WriteLine("Recursion");
int m = 0;
recursion();
void recursion()
{
    Console.Write(charArray1[m]);
    m++;
    if (m < charArray1.Length)
    {
        recursion();
    }
}
