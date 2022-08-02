/*
Задача 1: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой 
            строки двумерного массива.
Например, задан массив:

3 10 7 3
1 5 9 3
8 4 7 0
7 1 9 3

В итоге получается вот такой массив:

10 7 3 3
9 5 3 1
8 7 4 0
9 7 3 1
*/
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

        int[,] baseArray = ArrayRND();
        PrintArray(baseArray);

Console.WriteLine();

    for (int i = 0; i < baseArray.GetLength(0); i++)
            {
                for (int j = 1; j < baseArray.GetLength(1); j++)
                {
                    for (int jj = 0 ; jj < baseArray.GetLength(1)-j; jj++)
                    {
                        if (baseArray[i,jj] < baseArray[i,jj+1])
                            (baseArray[i,jj], baseArray[i,jj+1]) = (baseArray[i,jj+1], baseArray[i,jj]);
                    }   
                }

            }   
PrintArray(baseArray);