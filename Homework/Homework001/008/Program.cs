// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

System.Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(System.Console.ReadLine());
int R = 2;

while(N >= R)
{
    System.Console.WriteLine(R);
    R = R + 2;
}
