// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 26
// [-4, -6, 4, 67] -> 0

//метод находнения сумму элементов, стоящих на нечётных позициях.
int SumNumPositionNE(int[] baseArray)
{
    int sumNum = 0;
    for (int i = 0; i < baseArray.Length; i += 2)
    {
        sumNum += baseArray[i];
    }

    return sumNum;
}

//метод для вывода массива на экран
void printArray(int[] arrayIn)
{
    Console.Write("[");
    for (int i = 0; i < arrayIn.Length; i++)
    {
        Console.Write($"{arrayIn[i]} ");
    }
    Console.Write("]");
}

// тело основной программы

int[] inArray = { -4, -6, 4, 67 };

printArray(inArray);
Console.WriteLine($" --> {SumNumPositionNE(inArray)}.");
