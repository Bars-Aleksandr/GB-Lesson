// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12


//метод определения числа цифр в числе
int numberDigit(string stringVar)
{
    string numDigStr = stringVar.ToString();
    return numDigStr.Length;
}

// метод отделения последней цифры числа
int lastDigit(int initVar)
{
    int lastDigit = initVar % 10;
    return lastDigit;
}

//метод уменьшения количества цифр числа на последнюю
int modifNumber(int num)
{
    return num / 10;
}

Console.Write("Введите любое положительное целое число: ");
string stringDigit = Console.ReadLine();
int lengthDigit = numberDigit(stringDigit);

int IntDigit = int.Parse(stringDigit);
int originalNumber = IntDigit;
int sumDigit = 0;

for (int i = 1; i <= lengthDigit; i++)
{
    sumDigit = sumDigit + lastDigit(IntDigit);
    IntDigit = modifNumber(IntDigit);
}
Console.WriteLine($"{originalNumber} --> {sumDigit}");
