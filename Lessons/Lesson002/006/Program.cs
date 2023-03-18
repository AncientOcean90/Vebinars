// Вычислить : 1+2+4+8+...+ 2 в 10 степени (получить сумму от 2 в степени "0" до 2 в степени 10)

int x = 2;
int sum = 0;

for (int i = 0; i <= 10; i++)
{
sum = sum + (int)Math.Pow (x, i); 
System.Console.WriteLine(sum + (int)Math.Pow (x, i));
}

System.Console.WriteLine(sum);