Console.WriteLine("Введите положительное целое число, больше 1 ");
int n = Convert.ToInt32(Console.ReadLine());
int count= 2;
if (n > 1)
{
    int N=n-n%2;
    while (count<=N)
    {
        Console.WriteLine(count);
        count=count+2;
    }   
    
}
else 
{
    Console.WriteLine("Число ,должно быть больше 1 ");

}