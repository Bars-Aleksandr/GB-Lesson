// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные
// числа от 1 до N.
Console.WriteLine("Введите число N до которого необходимо вывести все четные числа");
int n = int.Parse(Console.ReadLine());

int count=1;

Console.Write("Четные числа ");

while (count<=n)
{
  if ((count % 2) == 0)
  {
    Console.Write($"{ count } ");
  }

  count++;

}
