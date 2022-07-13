// Задайте массив заполненный случайными положительными трёхзначными числами.
//Напишите программу, которая покажет количество чётных чисел в массиве.
// ПРИМЕР : [345, 897, 568, 234] -> 2


//метод создающий массив заданой длинны случайными числами
//int[] inputArrayRND(int length)
//{
//   int[] arrRND = new int[length];
//  for (int i = 0; i < length; i++)
// {
//     arrRND[i] = new Random().Next(0, 100);
// }

// return arrRND;
//}

//метод для вывода массива на экран
void printArray(int[] arrayIn)
{
    for (int i = 0; i < arrayIn.Length; i++)
    {
        Console.Write($"{arrayIn[i]} ");
    }
}

// тело основной программы
//Console.Write("Введите длину создаваемого массива ");
//int lengthArray = int.Parse(Console.ReadLine());

int[] inArray = { 345, 897, 568, 234 };
printArray(inArray);
