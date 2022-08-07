/*Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму 
            натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/
int SumNumbers(int m, int n)
{
if (n < m) return 0;
return SumNumbers(m, n-1) + n;

}

Console.Write("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(SumNumbers(M, N));