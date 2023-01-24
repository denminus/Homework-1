Console.Write("Введите номер дня недели: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n==1)
{
    Console.WriteLine("Первый день недели понедельник");
}
else if(n==2)
{
    Console.WriteLine("Второй день недели вторник");
}
else if(n==3)
{
    Console.WriteLine("Третий день недели среда");
}
else if(n==4)
{
    Console.WriteLine("Четвёртый день недели четверг");
}
else if(n==5)
{
    Console.WriteLine("Пятый день недели пятница");
}
else if(n==6)
{
    Console.WriteLine("Шестой день недели суббота");
}
else if(n==7)
{
    Console.WriteLine("Судьмой день недели Воскресенье");
}
else 
{
    Console.WriteLine("Дней с таким числом нет!");
}