//Напишите программу, которая задаёт массив из 8 элементов случайными числами и выводит их на экран.
//Оформите заполнение массива и вывод в виде функции (пригодится в следующих задачах)

//метод создающий массив заданой длинны случайными числами
int[] arrayRND(int length)
{
    int[] arrRND = new int[length];
    for (int i = 0; i < length; i++)
    {
        arrRND[i] = new Random().Next(0, 100);
    }

    return arrRND;
}

//метод для вывода массива на экран
void printArray(int[] arrayIn)
{
    // int lengthArr = arrayIn.Length;
    for (int i = 0; i < arrayIn.Length; i++)
    {
        Console.Write($"{arrayIn[i]} ");
    }
}

// тело основной программы
int lengthArray = 8;

//int[] myArray = arrayRND(lengthArray);
//printArray(myArray);

printArray(arrayRND(lengthArray));
