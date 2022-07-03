// 2. Напишите программу, которая выводит случайное число
// из отрезка [10, 99] и показывает наибольшую цифру числа. При помощи методов.
int Maxnumber(int num)
{

if (num % 10 > num / 10)
{
return num % 10;
}
else
return num / 10;
}
int SecondNum = new Random().Next(10, 100);
Maxnumber(SecondNum);

Console.WriteLine (SecondNum) ;
Console.WriteLine (Maxnumber(SecondNum)) ;