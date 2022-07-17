

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

Zadacha_17();
