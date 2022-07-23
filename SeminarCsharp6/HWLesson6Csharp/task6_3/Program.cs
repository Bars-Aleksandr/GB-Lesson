//Задача: Напишите программу, которая будет создавать копию заданного двумерного массива с помощью поэлементного копирования.


//создание случайного двумерного массива
int[,] arrayRND(int n, int m)
{
    int[,] arrRND = new int[n, m];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            arrRND[i,j] = new Random().Next(0, 100);    
        }
    }

    return arrRND;
}

//вывод двумерного массива на экран
void printArray(int[,] arrayIn, int n, int m)
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

Console.Write($"Введите число строк m= ");
int m = int.Parse(Console.ReadLine());

printArray(arrayRND(2, 5), 2, 5);