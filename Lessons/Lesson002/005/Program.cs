// Дано натуральное n. вычислить: 1 + 1/2 + 1/3 + 1/4 + ... + 1/n.

int n = Convert.ToInt32(Console.ReadLine());
double sum = 0;

for (int i = 1; i <= n; i++)
{
sum = sum + (double)1 / (double)i;    // sum += (double)1 / (double)i;
System.Console.WriteLine((double)1 / (double)i);
}

System.Console.WriteLine(sum);