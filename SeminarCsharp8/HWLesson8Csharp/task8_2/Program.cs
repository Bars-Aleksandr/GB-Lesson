/*
Задача 2: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей 
суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/
    int[,] ArrayRND()
    {
       int n = new Random().Next(1, 10);
       int m = new Random().Next(2, 9);
       
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
                Console.Write($"{arrayIn[i, j], 3} ");
            }

            Console.WriteLine();
        }
    }
    
    int NumberesRow(int[, ] workArray)
    {
        int numRow = 0;
        int minSum = 0;

        for (int j = 0; j < workArray.GetLength(1); j++)
            {
                 minSum += workArray[0, j];
            }

        int sumOfElement = 0;
        for (int i = 0; i < workArray.GetLength(0); i++)
        {
            for (int j = 0; j < workArray.GetLength(1); j++)
            {
                sumOfElement = sumOfElement + workArray[i, j];
            }
            if (minSum > sumOfElement)
            {
                minSum = sumOfElement;
                numRow = i;
            }
            sumOfElement = 0;
        }
        return numRow;
    }



int[,] baseArray = ArrayRND();

Console.WriteLine("Исходный сгенерированный массив");
PrintArray(baseArray);

Console.Write($"номер строки с наименьшей суммой = {NumberesRow(baseArray) + 1}");
Console.WriteLine();