// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.Write("Введите первое число и нажмите клавишу Enter: ");
int a = int.Parse(Console.ReadLine());

Console.Write("Введите второе число и нажмите клавишу Enter: ");
int b = int.Parse(Console.ReadLine());

Console.Write("Введите третье число и нажмите клавишу Enter: ");
int d = int.Parse(Console.ReadLine());
int max;
if (a > b)
{
   max = a;
}
else
{
    max = b;
}
if (d > max)
{
    max = d;
}

Console.WriteLine($"Максимальное число {max} ");