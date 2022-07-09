// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16
//double Exponent(double digital, int exp);


//{
//    for (int count = 1; count < exp; count++)
//    {
//        digital = digital * digital;
//    }
//    return digital;
//}

Console.Write("Введите число, которое необходимо возвести в степень ");
double A = double.Parse(Console.ReadLine());

Console.Write("Введите натуральную степень, в которую необходимо возвести введенное число ");
int B = int.Parse(Console.ReadLine());
if (B <= 0)
{
    Console.WriteLine(" Вы ввели не натуральную степень");
}

// Console.WriteLine($"Число {A} при возведении в натуральную степень {B} равно {Exponent(A, B)}");
