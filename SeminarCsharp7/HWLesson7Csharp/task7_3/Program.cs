// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.


int[,] ArrayRND()
        {
            int n = new Random().Next(1, 5);
            int m = new Random().Next(1, 6);

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

// вывод массива на экран
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

int summaNumbersColumn = 0;
int numberColumn = 1;

for (int j = 0; j < baseArray.GetLength(1); j++)
    {
    for (int i = 0; i < baseArray.GetLength(0); i++)
        {
            summaNumbersColumn = summaNumbersColumn + baseArray[i,j];
        }
    Console.WriteLine($"{numberColumn}-го столбца {Math.Round( (double) summaNumbersColumn/baseArray.GetLength(0),2 )} "); 
    numberColumn++ ;   
    summaNumbersColumn = 0;   
    }