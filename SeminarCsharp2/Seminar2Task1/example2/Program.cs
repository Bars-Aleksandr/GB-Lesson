// 2. Напишите программу, которая выводит случайное число
// из отрезка [10, 99] и показывает наибольшую цифру числа. При помощи методов.

//First the metod
int LastDigit(int num)
{
    return num % 10;
}

// Second the Metod
int Maxnumber(int num)
{
    if (LastDigit(num) > num / 10)
    {
        return LastDigit(num);
    }
    else
        return num / 10;
}

int SecondNum = new Random().Next(10, 100);

Console.WriteLine(SecondNum);
Console.WriteLine(Maxnumber(SecondNum));
