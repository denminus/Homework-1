Console.WriteLine("Введите трёхзначное число");
int n = Convert.ToInt32(Console.ReadLine());
if (n>=100)
{
    Console.Write("Последней цифрой вашего числа является  ");
    Console.WriteLine(n%10); 

}
else {
    Console.WriteLine("Третьей цифры нет");
}