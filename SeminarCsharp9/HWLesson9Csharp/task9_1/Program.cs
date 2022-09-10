/*Задача 1: Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.

M = 1; N = 5 -> "2, 4"
M = 4; N = 8 -> "4, 6, 8"
*/
    void EvenNumbersMtoN(int m, int n)
    {
    if (n < m) return;
    
    EvenNumbersMtoN(m, n - 2);
    Console.Write($"{n}, ");
    }

Console.Write("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

if (N % 2 == 0)
{
    EvenNumbersMtoN(M, N);
}
else
{
    EvenNumbersMtoN(M, N - 1);
}

