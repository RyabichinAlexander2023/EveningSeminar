// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
/*

int CutNumber(int num)
{
    int hunders = num /100;
    int ones  = num % 10;

    int result = hunders * 10 + ones;
    return result;
}

int randNumber = new Random().Next(100 , 1000);

int newNumber = CutNumber(randNumber);
Console.WriteLine($"New version of {randNumber} is {newNumber}");
*/

// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно a и b.

/*
bool IsDivided(int number, int firstDivider, int secondDivider)
{
    if(number % firstDivider == 0 && number % secondDivider == 0) // или return number % firstDivider == 0 && number % secondDivider == 0;
    {
        return True;
    }
    else
    {
        return false;
    }
}
Console.Write("Input a number for cheking: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number fdivider: ");


int num = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number for cheking: ");
int num = Convert.ToInt32(Console.ReadLine());
*/

// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

int ShowNum(int randomNum)
{
    int tens = number/10;
    int ones = number %10;


    if (tens > ones)
    {
        return tens;
    }
    else
    {
        return ones;
    }
}
int randomNum = new Random().Next(10,100);
Console.Write($"{randomNum} {ShoeNum (RandomNum)}");

// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

bool IsKvadrat(int num1, int num2)
{
 return  num1 == num2 * num2 || num2 == num1 * num1; 
}

// void MyMethod(int number) 2 -я через цикл делить на 10 пока не станет 3 значной 
// 3-я bool