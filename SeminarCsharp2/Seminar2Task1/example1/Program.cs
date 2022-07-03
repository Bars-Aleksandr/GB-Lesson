// Напишите программу, которая принимает на вход трехзначное число и на выходе показывает последнюю цифру этого числа
int LastDigit(int num)
{
return num % 10;
}
Console.Write("Введите трехзначное число и нажмите клавишу Enter: ");
int Number = int.Parse(Console.ReadLine());
Console.WriteLine(LastDigit(Number));
