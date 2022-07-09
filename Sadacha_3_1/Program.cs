Console.Write("Введите число дня недели: ");
int number_week = Convert.ToInt32(Console.ReadLine());

if(number_week == 1)
{
    Console.WriteLine("Сегодня - понедельник");
}
else if(number_week == 2)
{
    Console.WriteLine("Сегодня - вторник");
}
else if(number_week == 3)
{
    Console.WriteLine("Сегодня - среда");
}
else if(number_week == 4)
{
    Console.WriteLine("Сегодня - четверг");
}
else if(number_week == 5)
{
    Console.WriteLine("Сегодня - пятница");
}
else if(number_week == 6)
{
    Console.WriteLine("Сегодня - суббота");
}
else if(number_week == 7)
{
    Console.WriteLine("Сегодня - воскресенье!");
}
else
{
    Console.WriteLine("Указано неккоректное число дня недели");
}
