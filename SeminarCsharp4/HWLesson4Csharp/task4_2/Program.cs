// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12
int numberDigit(string stringVar)
{
    string numDigStr = stringVar.ToString();
    return numDigStr.Length;
}

//int SeparationDigit(int initVar)
//{
// A = A / 10;
//}
Console.Write("Введите любое положительное целое число: ");
string stringDigit = Console.ReadLine();
int size = numberDigit(stringDigit);

//string numDigStr = stringVar.ToString();
//int size = numDigStr.Length;

Console.WriteLine(size);
