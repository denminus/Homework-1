Console.WriteLine("Введите трёхзначное число");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Второй цифрой вашего числа является  ");
Console.WriteLine((n%100-n%10)/10);
