// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние 
// между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09 A (7,-5); B (1,-1) -> 7,21

// Формула вычисления расстояния между двумя точками A(xa, ya) и B(xb, yb) на плоскости: 
// AB = √((xb - xa)2 + (yb - ya)2).

double XA = Convert.ToDouble (Console.ReadLine());
double YA = Convert.ToDouble (Console.ReadLine());
double XB = Convert.ToDouble (Console.ReadLine());
double YB = Convert.ToDouble (Console.ReadLine());

double lengthX = Math.Pow(XB-XA, 2);
double lengthY = Math.Pow(YB-YA, 2);

double result = Math.Round(Math.Sqrt(lengthX + lengthY), 2);

System.Console.WriteLine("distance: " + result);