Console.WriteLine("Введите число на отрезке [10,99]");
int n = Convert.ToInt32(Console.ReadLine());
int number1 = n / 10;
int number2 = n % 10;
int max=0;
if (number1 > number2)
{
    max = number1;
}
else {
    max = number2;
}

Console.Write("Наибольшая цифра числа ");
Console.WriteLine(max);