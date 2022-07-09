// Напишите программу, которая принимает на
//вход цифру, обозначающую день недели, и проверяет,
//является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет
void Weekend(int num)
{
    if (num == 6 || num == 7)
    {
        Console.WriteLine($"{num} --> да");
    }
    else
    {
        Console.WriteLine($"{num} --> нет");
    }
}
Console.WriteLine("Введите число соответсвующее дню недели и нажмите клавишу Enter: ");
int Number = int.Parse(Console.ReadLine());
Weekend(Number);
