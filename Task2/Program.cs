Console.Write("Введите число большее число, не меньше единицы ");
double bignumber = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите число меньшее число ");
double smallnumber = Convert.ToDouble(Console.ReadLine());
double n=bignumber/smallnumber;
if (smallnumber==n) 
{
    Console.WriteLine("Большее число является квадратом меньшего");
}
else 
{
    Console.WriteLine("Большее число не является  квадратом меньшего");


}
