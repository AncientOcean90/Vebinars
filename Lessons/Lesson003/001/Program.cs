﻿// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат 
// точек в этой четверти (x и y).

System.Console.WriteLine("Введите номер четверти");
int quarter = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Результат: ");

if (quarter == 1)
{
   System.Console.WriteLine("X > 0,  Y > 0");
}
else if (quarter == 2)
{
    System.Console.WriteLine("X < 0,  Y > 0");
}
else if (quarter == 3)
{
    System.Console.WriteLine("X < 0,  Y < 0");
}
else if (quarter == 4)
{
    System.Console.WriteLine("X > 0,  Y < 0");
}
 else 
{
     System.Console.WriteLine("Такой четверти не существует");
}