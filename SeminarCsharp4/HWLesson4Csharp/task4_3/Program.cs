//Напишите программу, которая задаёт массив из 8 элементов случайными числами и выводит их на экран.
//Оформите заполнение массива и вывод в виде функции (пригодится в следующих задачах)

//метод создающий массив заданой длинны случайными числами
int[] arrayRND(int length)
{
    int[] arrRND = new int[length];
    for (int i = 0; i <= length; i++)
    {
        arrRND[i] = new Random().Next();
    }
    return arrRND;
}

int lengthArray = 7;
//arrayRND(lengthArray);
