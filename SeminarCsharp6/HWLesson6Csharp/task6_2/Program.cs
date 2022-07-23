 //Напишите программу, которая найдёт точку пересечения двух прямых,
 // заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.


double ResultX(double copyB1, double copyK1, double copyB2, double copyK2)
{
   return (copyB2 - copyB1) / (copyK1 - copyK2);
}

double ResultY(double X, double copyK1, double copyB1)
{
   return copyK1*X + copyB1;
}

Console.Write("Введите значение b1= ");
double b1 = double.Parse(Console.ReadLine());

Console.Write("Введите значение k1= ");
double k1 = double.Parse(Console.ReadLine());

Console.Write("Введите значение b2= ");
double b2 = double.Parse(Console.ReadLine());

Console.Write("Введите значение k2= ");
double k2 = double.Parse(Console.ReadLine());
    

double x = ResultX(b1, k1, b2, k2);
double y = ResultY(x, k1, b1);

Console.WriteLine($"Координаты точки пересечения двух прямых ({x,2} , {y,2})");