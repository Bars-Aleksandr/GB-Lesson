// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру
// этого числа.
void DelAverageDigital(int Number)
{
    Console.WriteLine($"{Number}-->{Number / 100}{Number % 10}");
}
int RND = new Random().Next(100, 1000);
Console.WriteLine(RND);
DelAverageDigital(RND);
