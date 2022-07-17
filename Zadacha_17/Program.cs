

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
int Chetv = random.Next(1, 5); // не забываем, что 5 не входит в промежуток
Console.WriteLine($"Выбрана четверть ({Chetv})");

if (Chetv == 1) Console.WriteLine("Координата х > 0, координата у > 0");
else if (Chetv == 2) Console.WriteLine("Координата х < 0, координата у > 0");
else if (Chetv == 3) Console.WriteLine("Координата х < 0, координата у < 0");
else if (Chetv == 4) Console.WriteLine("Координата х > 0, координата у < 0");
}
//Zadacha_18();

void Zadacha_21()
// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и 
// находит расстояние между ними в 2D пространстве
{
Console.WriteLine("Введите координату первой точки: ");
int Numberx1 =  Convert.ToInt32(Console.ReadLine());
int Numbery1 =  Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату второй точки: ");
int Numberx2 =  Convert.ToInt32(Console.ReadLine());
int Numbery2 =  Convert.ToInt32(Console.ReadLine());

int x = Numberx2 - Numberx1;
int y = Numbery2 - Numbery1;

// возведение в степень Math.Pow(x, 2) - возвежение х в квадрат
// извлечение корня с помощь степени Math.Pow(x, 1/2) - возвежение х в 1/2 степень - извлечение квадратного корня
// извлечение корня Math.Sqrt(x) - извлечение квадратного корня из х
// int S имспоьзовать нельзя!!

double S = Math.Sqrt(x*x + y*y); // возведение в квадрат возвращает переменной формат double!!

// S = Math.Round(S, 2); - либо так

Console.WriteLine("Расстояние от точки 1 до точки 2 составляет " + Math.Round(S, 2));
                                                            //округление числа до второго знака
}

// Zadacha_21();

void Zadacha_22()
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу 
// квадратов чисел от 1 до N
{
    Console.WriteLine("Введите число: ");
    int Number =  Convert.ToInt32(Console.ReadLine());
    int count = 1;
    double Result = 1;
    while (count <= Number)
    {
        Result = Math.Pow(count, 2);
        count++;
        Console.WriteLine(Result);
    }
}
    Zadacha_22();
    
