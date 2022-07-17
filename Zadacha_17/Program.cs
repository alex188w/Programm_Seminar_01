

void Zadacha_17()
{
// 17. Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт 
// номер четверти плоскости, в которой находится эта точка.

//Console.WriteLine("Введите координату х и нажмите клавишу Enter: ");
//int Number1 =  Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Введите координату у и нажмите клавишу Enter: ");
//int Number1 =  Convert.ToInt32(Console.ReadLine());

Random random = new Random();
int x = random.Next(-10, 11);
int y = random.Next(-10, 11);
Console.WriteLine($"Точка с координатами ({x}, {y})");
// $ - обозначае5т интерполяцию строки, вместо х и у подставятся их значения,
// внутри кавычек будут стоять переменные, выделенные {}
if (x > 0 && y > 0) Console.WriteLine("Точка лежит в первой четверти координатной плоскости");
else if (x < 0 && y > 0) Console.WriteLine("Точка лежит во второй четверти координатной плоскости");
else if (x < 0 && y < 0) Console.WriteLine("Точка лежит в третьей четверти координатной плоскости");
else if (x > 0 && y < 0) Console.WriteLine("Точка лежит в четвертой четверти координатной плоскости");
else Console.WriteLine("Точка лежит на оси координат");
}
// for (int i = 1; i < 10; i++) // цикл количество итераций = 10
// Zadacha_17();

void Zadacha_18()
// Задача 18: Напишите программу, которая по заданному номеру четверти, показывает диапазон 
// возможных координат точек в этой четверти (x и y)
{
Random random = new Random();
int Chetv = random.Next(1, 4);
Console.WriteLine($"Выбрана четверть ({Chetv})");

if (Chetv == 1) Console.WriteLine("Координата х > 0, координата у > 0");
else if (Chetv == 2) Console.WriteLine("Координата х < 0, координата у > 0");
else if (Chetv == 3) Console.WriteLine("Координата х < 0, координата у < 0");
else if (Chetv == 4) Console.WriteLine("Координата х > 0, координата у < 0");
}
Zadacha_18();