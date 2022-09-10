 int[,] ArrayRND()
    {
       int n = new Random().Next(1, 10);
       int m = new Random().Next(1, 10);
       
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

    int[,] SortingArray(int[,] arr)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 1; j < arr.GetLength(1); j++)
                {
                    for (int jj = 0 ; jj < arr.GetLength(1)-j; jj++)
                    {
                        if (arr[i,jj] < arr[i,jj+1])
                            (arr[i,jj], arr[i,jj+1]) = (arr[i,jj+1], arr[i,jj]);
                    }   
                }

            }   
        return arr;    
    }


int[,] baseArray = ArrayRND();

Console.WriteLine("Исходный сгенерированный массив");
PrintArray(baseArray);

Console.WriteLine();

Console.WriteLine("Отсортированный массив");
PrintArray(SortingArray(baseArray));
