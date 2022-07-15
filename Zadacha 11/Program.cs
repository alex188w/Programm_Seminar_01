// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого 
//числа

Random rand = new Random();
int number = rand.Next(100, 1000); // [10, 100)
Console.WriteLine("Случайное число");
Console.WriteLine(number);

int ones = number % 10;
int tens = number / 10 % 10; // пример разбивки трехзначного числа на составляющие цифры
int hungs = number / 100;

int result = ones + hungs * 10;
Console.WriteLine(result);
