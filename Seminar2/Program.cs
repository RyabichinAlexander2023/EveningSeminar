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
     return number % firstDivider == 0 && number % secondDivider == 0;

// МОЖНО ЗАПИСАТЬ ТАК ВЕРХНЮЮ СТРОЧКУ
//  if(number % firstDivider == 0 && number % secondDivider == 0)
//    {
//        return True;
//   }
//    else
//    {
//        return false;
//   }
}
Console.Write("Input a number for cheking: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a first divider: ");
int div1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second divider: ");
int div2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(IsDivided(num, div1, div2));
*/

// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

/*
int ShowNum(int randomNum)
{
    int tens = randomNum / 10;
    int ones = randomNum % 10;


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
Console.Write($"{randomNum} {ShowNum(randomNum)}");
*/

// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
/*
bool IsQuad(int first, int second)
{
if(first == second*second || second == first*first)
{
 return  true;
}
else return false;
}
Console.Write("Input a first number for cheking: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(IsQuad(num1,num2));
*/