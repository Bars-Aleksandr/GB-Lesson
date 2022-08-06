/* Задача 4. Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, 
на пересечении которых расположен наименьший элемент массива.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Наименьший элемент - 1, на выходе получим
следующий массив:
9 4 2
2 2 6
3 4 7
*/
int[, ] ArrayRND(int n, int m)
    {
        int[,] arrRND = new int[n, m];

        for (int i = 0; i < n; i++)
            {
            for (int j = 0; j < m; j++)
                {
                    arrRND[i, j] = new Random().Next(0, 10);
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
                Console.Write($"{arrayIn[i, j],4} ");
            }

            Console.WriteLine();
        }
    }

    void PrWithoutRowColumn(int[, ] arrWork, int rowDel, int columnDel)
    {
        int N = arrWork.GetLength(0);
        int M = arrWork.GetLength(1);

        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < M; j++)
            {
                if ((i != rowDel) & (j != columnDel))
                {
                    Console.Write($"{arrWork[i, j],4} ");
                }
            }
            Console.WriteLine();
        }
    }



Console.Write("Введите число строк в массиве ");
int rows = int.Parse(Console.ReadLine());

Console.Write("Введите число столбцов в массиве ");
int columns = int.Parse(Console.ReadLine());

int[, ] baseArray = new int [rows, columns];
baseArray = ArrayRND(rows, columns);
PrintArray(baseArray);

int minRow = 0;
int minColumn = 0;
int minElement = baseArray[0,0];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
           if ( minElement > baseArray[i, j] )
            {
                minElement = baseArray[i,j];
                minRow = i;
                minColumn = j;
            }
        }
    }
Console.WriteLine($"Наименьший элемент= {minElement}");
Console.WriteLine($"Получившийся массив после удаления :");

PrWithoutRowColumn(baseArray, minRow, minColumn);
