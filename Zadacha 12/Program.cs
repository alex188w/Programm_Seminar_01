// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе 
// число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления

Console.WriteLine("Введите первое число и нажмите клавишу Enter: ");
int Number1 =  Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число и нажмите клавишу Enter: ");
int Number2 =  Convert.ToInt32(Console.ReadLine());
int div = Number2 % Number1;

if (div == 0)
Console.WriteLine ("второе число является кратным первому");
else 
{
   Console.WriteLine ("Осьаьок от деления составляет"); 
   Console.WriteLine (div);
}