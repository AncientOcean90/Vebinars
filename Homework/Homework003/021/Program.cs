// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

double xa = Convert.ToDouble (Console.ReadLine());
double ya = Convert.ToDouble (Console.ReadLine());
double za = Convert.ToDouble (Console.ReadLine());

double xb = Convert.ToDouble (Console.ReadLine());
double yb = Convert.ToDouble (Console.ReadLine());
double zb = Convert.ToDouble (Console.ReadLine());

double lengthX = Math.Pow(xb-xa, 2);
double lengthY = Math.Pow(yb-ya, 2);
double lengthZ = Math.Pow(zb-za, 2);

double result = Math.Round(Math.Sqrt(lengthX + lengthY + lengthZ), 2);

System.Console.WriteLine("distance: " + result);
