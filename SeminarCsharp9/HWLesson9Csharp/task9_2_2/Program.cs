int SumNumbers(int m, int n)
{
   int sumNum = 0;
   for (int i = m; i <= n; i++)
   {
    sumNum = sumNum + i;    
   }
   return sumNum;
}

Console.Write("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(SumNumbers(M, N));