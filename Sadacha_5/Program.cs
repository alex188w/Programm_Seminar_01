int number = 5;
int result = Power(number);
Console.WriteLine(result);

int Power(int currentNumber)
{
    return currentNumber * currentNumber;
}

//На момент выполнения программа будет знать что такое ф-я Power
//Поэтому выполнение программы - первыет три строчки