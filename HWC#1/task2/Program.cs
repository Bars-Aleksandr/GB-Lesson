Console.Write("Введите первое число и нажмите клавишу Enter: ");
int a = int.Parse(Console.ReadLine());

Console.Write("Введите второе число и нажмите клавишу Enter: ");
int b = int.Parse(Console.ReadLine());
int max, min;
if (a>b)
{
   max = a; min = b ;
}
else
{
    max = b; min = a;
}
Console.WriteLine($"Большее число { max } ,а меньшее число  { min }");