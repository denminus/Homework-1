Console.Write("Введите делимое число ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите делитель ");
int b = Convert.ToInt32(Console.ReadLine());
int n=a%b;

if (n==0)
{
    Console.Write("Делимое число кратно делителю");
}
else
{
    Console.Write($"Делимое число не кратно делителю. Остаток {n}");
}
