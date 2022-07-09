// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

Console.Write("Введите число, которое необходимо возвести в степень ");
double A = double.Parse(Console.ReadLine());

Console.Write("Введите степень, в которую необходимо возвести введенное число ");
int B = int.Parse(Console.ReadLine());
double ACopy = A;
for (int count = 1; count < B; count++)
{
    ACopy = ACopy * ACopy;
}
Console.WriteLine($"Число {A} при возведении в натуральную степень {B} равно {ACopy}");
