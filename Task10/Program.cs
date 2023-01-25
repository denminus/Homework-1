Console.WriteLine("Введите трёхзначное число");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Без второй цифры: ");

int n1=n/100;
int n2=n%10;
Console.WriteLine($"{n1}_{n2}");
