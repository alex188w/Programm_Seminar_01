// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23

Console.WriteLine("Введите число и нажмите клавишу Enter: ");
int Number1 =  Convert.ToInt32(Console.ReadLine());
int a =  7;
int b = 23;
int div1 = Number1 % a;
int div2 = Number1 % b;

if (div1 == 0 && div2 == 0) //сложное условие - объединение двух условий
Console.WriteLine("Введенное число является кратным 7 и 23");
else 
Console.WriteLine("Введенное число не является кратным 7 и 23");