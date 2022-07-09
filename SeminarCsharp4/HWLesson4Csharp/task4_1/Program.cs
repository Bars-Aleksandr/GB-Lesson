// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16
double Exponent(double digital, int exp)
{
    double result = 1;

    for (int count = 1; count <= exp; count++)
    {
        result = result * digital;
    }

    return result;
}

Console.Write("Введите число, которое необходимо возвести в степень ");
double A = double.Parse(Console.ReadLine());

Console.Write("Введите натуральную степень, в которую необходимо возвести введенное число ");
int B = int.Parse(Console.ReadLine());
Exponent(A, B);
if (B <= 0)
{
    Console.WriteLine(" Вы ввели не натуральную степень");
}
else
{
    Console.WriteLine($"Число {A} при возведении в натуральную степень {B} равно {Exponent(A, B)}");
}
