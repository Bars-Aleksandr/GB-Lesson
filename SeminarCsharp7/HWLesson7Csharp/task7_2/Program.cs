//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

//Например, задан массив:

//1 4 7 2

//5 9 2 3

//8 4 2 4

//1 7 -> такого числа в массиве нет

internal class Program
{
    private static void Main(string[] args)
    {
        //создание случайного двумерного массива
        int[,] ArrayRND()
        {
            int n = new Random().Next(1, 10);
            int m = new Random().Next(1, 10);
            //int n = 3;
            //int m = 5;
            int[,] arrRND = new int[n, m];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    arrRND[i, j] = new Random().Next(-10, 10);
                }
            }

            return arrRND;
        }

        //вывод двумерного массива на экран
        void PrintArray(int[,] arrayIn)
        {
            for (int i = 0; i < arrayIn.GetLength(0); i++)
            {
                for (int j = 0; j < arrayIn.GetLength(1); j++)
                {
                    Console.Write($"{arrayIn[i, j]} ");
                }

                Console.WriteLine();
            }
        }

        int[,] arr = ArrayRND();
        PrintArray(arr);

        Console.Write($"Введите позицию числа по вертикали i= ");
        int i1 = int.Parse(Console.ReadLine());

        Console.Write($"Введите позицию числа по горизонтали j=");
        int j1 = int.Parse(Console.ReadLine());
       
        if (i1 <= arr.GetLength(0) & j1 <= arr.GetLength(1) &
                i1 > 0 & j1 > 0
            )
        {
            Console.WriteLine($"Данной позиции соответсвует число {arr[i1 - 1, j1 - 1]} ");
        }
        else
        {
            Console.WriteLine("Числа с данной позицией нет");
        }
    }
}