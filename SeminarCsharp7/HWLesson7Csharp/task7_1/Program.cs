// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9

//создание случайного двумерного массива
double[,] ArrayRND(int n, int m)
{
    double[,] arrRND = new double[n, m];
    Random nRND = new Random();
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            arrRND[i,j] = Math.Round(nRND.NextDouble()*(10+10)-10,1);    
        }
    }

    return arrRND;
}

//вывод двумерного массива на экран
void PrintArray(double[,] arrayIn, int n, int m)
{
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            Console.Write($"{arrayIn[i,j]} ");
        }

        Console.WriteLine();
    }
}


Console.Write($"Введите число строк n= ");
int n = int.Parse(Console.ReadLine());

Console.Write($"Введите число столбцов m= ");
int m = int.Parse(Console.ReadLine());


Console.WriteLine("Полученый массив заполненый случайными числами");
PrintArray(ArrayRND(n,m),n,m);
Console.WriteLine();

