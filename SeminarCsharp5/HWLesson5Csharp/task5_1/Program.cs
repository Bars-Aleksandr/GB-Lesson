// Задайте массив заполненный случайными положительными трёхзначными числами.
//Напишите программу, которая покажет количество чётных чисел в массиве.
// ПРИМЕР : [345, 897, 568, 234] -> 2


// Поиск количество чётных чисел в массиве

int amountEvenNum(int[] baseArray)
{
    int count = 0;
    for (int i = 0; i < baseArray.Length; i++)
    {
        if ((baseArray[i] % 2) == 0)
        {
            count++;
        }
    }

    return count;
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

int[] inArray = { 344, 898, 568, 234 };

printArray(inArray);
Console.WriteLine($" четных элементов в заданном массиве - {amountEvenNum(inArray)}.");
