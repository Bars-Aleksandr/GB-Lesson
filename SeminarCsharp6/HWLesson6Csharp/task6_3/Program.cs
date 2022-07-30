//Задача: Напишите программу, которая будет создавать копию заданного двумерного массива с помощью поэлементного копирования.


//создание случайного двумерного массива
int[,] ArrayRND(int n, int m)
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
void PrintArray(int[,] arrayIn, int n, int m)
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


// копирование двумерного массива
int[,] CopyingArray(int[,] inputArray)
{
    int[,] arr = new int[inputArray.GetLength(0), inputArray.GetLength(1)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i,j] = inputArray[i,j];    
        }
    }

    return arr;
}


Console.Write($"Введите число строк n= ");
int n = int.Parse(Console.ReadLine());

Console.Write($"Введите число столбцов m= ");
int m = int.Parse(Console.ReadLine());


int[,] baseArray = new int[n,m];
int[,] copyArray = new int[n,m];

baseArray = ArrayRND(n,m);
Console.WriteLine("Исходный массив заполненый случайными целыми числами");
PrintArray(baseArray,n,m);
Console.WriteLine();

copyArray = CopyingArray(baseArray);
Console.WriteLine("Скопированный массив");
PrintArray(copyArray,n,m);