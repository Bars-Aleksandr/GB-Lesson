// Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
// ПРИМЕР: [3, 7, 22, 2, 78] -> 76

//метод создающий массив заданой длинны случайными числами
double[] arrayRND(int length)
{
    double[] arrRND = new double[length];
    for (int i = 0; i < length; i++)
    {
        arrRND[i] = new Random().Next(-100, 100);
    }

    return arrRND;
}

//метод находнения min-элемент одномерного массива.
double[] SearchMinMax(double[] baseArray)
{
    double[] MinMaxArr = new double[2]; //создали массив в котором первым элементом будет min значение, а вторым max значение
    MinMaxArr[0] = baseArray[0];
    MinMaxArr[1] = baseArray[1];
    for (int i = 2; i < baseArray.Length; i++)
    {
        if (baseArray[i] < MinMaxArr[0])
        {
            MinMaxArr[0] = baseArray[i];
        }
        if (baseArray[i] > MinMaxArr[1])
        {
            MinMaxArr[1] = baseArray[i];
        }
    }

    return MinMaxArr;
}

//метод для вывода массива на экран
void printArray(double[] arrayIn)
{
    Console.Write("[ ");
    for (int i = 0; i < arrayIn.Length; i++)
    {
        Console.Write($"{arrayIn[i]} ");
    }
    Console.Write("]");
}

// тело основной программы

Console.Write("Введите длину массива ");
int lengthMas = int.Parse(Console.ReadLine());

double[] sourceArray = arrayRND(lengthMas);

printArray(sourceArray);

Console.WriteLine($" --> {SearchMinMax(sourceArray)[1] - SearchMinMax(sourceArray)[0]}.");
