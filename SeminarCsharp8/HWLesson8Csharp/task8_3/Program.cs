/*Задача 3: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

Например, заданы 2 массива:

1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

и

1 5 8 5
4 9 4 2
7 2 2 6
2 3 4 7

Их произведение будет равно следующему массиву:

1 20 56 10
20 81 8 6
56 8 4 24
10 6 24 49
*/
 int[, ] ArrayRND(int n)
    {
        int[,] arrRND = new int[n, n];

        for (int i = 0; i < n; i++)
            {
            for (int j = 0; j < n; j++)
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
                Console.Write($"{arrayIn[i, j],4} ");
            }

            Console.WriteLine();
        }
    }
    int[, ] MultiplicationArray(int[, ] arr1, int[, ] arr2)
    {
        int[, ] resultArr = new int[arr1.GetLength(0), arr1.GetLength(0)];
        for (int i = 0; i < arr1.GetLength(0); i++)
        {
            for (int j = 0; j < arr1.GetLength(1); j++)
            {
                resultArr[i, j] = arr1[i, j] * arr2[i, j];
            }
        }
        return resultArr;
    }


Console.Write("Введите размер матриц: ");
int size = int.Parse(Console.ReadLine());

int[, ] matrix1 = ArrayRND(size);
int[, ] matrix2 = ArrayRND(size);

PrintArray(matrix1);
Console.WriteLine("и");
PrintArray(matrix2);

Console.WriteLine("Их произведение будет равно следующему массиву:");
PrintArray(MultiplicationArray(matrix1, matrix2));