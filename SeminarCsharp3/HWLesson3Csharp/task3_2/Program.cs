//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53
//Формула вычисления расстояния между двумя точками A(xa, ya, za) и B(xb, yb, zb) в пространстве:
//AB = √(xb - xa)2 + (yb - ya)2 + (zb - za)2
double DistanceXYZ(double x1, double y1, double z1, double x2, double y2, double z2)
{
    return (Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2)));
}

//Ввод координат точки А
Console.Write("Введите x точки А : ");
double x1 = double.Parse(Console.ReadLine());

Console.Write("Введите y точки А : ");
double y1 = double.Parse(Console.ReadLine());

Console.Write("Введите z точки А : ");
double z1 = double.Parse(Console.ReadLine());

//Ввод координат точки В
Console.Write("Введите x точки B : ");
double x2 = double.Parse(Console.ReadLine());

Console.Write("Введите y точки B : ");
double y2 = double.Parse(Console.ReadLine());

Console.Write("Введите z точки B : ");
double z2 = double.Parse(Console.ReadLine());

//                           x1,y1,z1 x2, y2,z2
Console.WriteLine($"Растояние между точками равно {DistanceXYZ(x1, y1, z1, x2, y2, z2)}");
