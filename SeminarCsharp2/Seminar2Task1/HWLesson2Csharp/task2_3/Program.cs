//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры
//нет.
//645 -> 5
//78 -> третьей цифры нет
//326
void LastDigital(int Number)
{
    Console.WriteLine($"{Number} --> {Number % 10}");
}
Console.WriteLine("Введите число и нажмите клавишу Enter: ");
int Number = int.Parse(Console.ReadLine());

if (Number < 100)
{
    Console.WriteLine($"{Number} --> третьей цифры нет");
}
else
{
    LastDigital(Number);
}
