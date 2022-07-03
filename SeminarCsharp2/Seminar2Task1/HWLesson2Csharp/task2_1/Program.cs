//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую
//цифру этого числа.
int AverageDigit(int num)
{
    return (num / 10) % 10;
}
Console.WriteLine("Введите трехзначное число и нажмите клавишу Enter: ");
int Number = int.Parse(Console.ReadLine());

if (Number > 99 & Number < 1000)
{
    Console.WriteLine(AverageDigit(Number));
}
else
{
    Console.WriteLine("Вы ввели не трехзначное число ");
}
