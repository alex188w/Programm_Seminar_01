//Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает 
//наибольшую цифру числа

//int number = 5;
Random rand = new Random();
//<Тип данныхЮ имя = new <тип данных>();
//for (int i = 0; i < 25; i++) - работа цикла for 
//{
int number = rand.Next(10, 100); // [10, 100) - 100 не входит в данный промежуток
Console.WriteLine(number);
//};

int ones = number % 10;
int tens = number /10; //int/int получаем - int (целочисленное деление)
        //таким образом можно разбить любое число на составляющие цифры
if (ones > tens) Console.WriteLine(ones);
else Console.WriteLine(tens);