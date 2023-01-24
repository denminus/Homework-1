Console.Write("Введите первое число ");
double a = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите второе число ");
double b = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите третье число ");
double c = Convert.ToDouble(Console.ReadLine());

double max=a;

if ( b>max ) max = b;
if ( c>max ) max = c;

Console.Write("Максимальное число= ");
Console.WriteLine(max);