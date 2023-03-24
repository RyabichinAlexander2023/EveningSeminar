// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает,
// что третьей цифры нет.

/*
int number = ReadInt("Введите число: ");
int count = number.ToString().Length;
Console.Write(MakeArray(number, count));
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
int MakeArray(int a, int b)
{
int result = 0;
    if (b < 3)
    {
        Console.Write("Третьей цифры нет: ");
    }
    else
    {
        int c = 1;
        for (int i = b; i > 3; i--)
        {
            c = c * 10;
        }

        result = (a / c) % 10;
    }
return result;
}
*/

//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе 
//показывает вторую цифру этого числа.

/*
int number = ReadInt("Введите трехзначное число: ");
int amount = number.ToString().Length;

if (amount < 3 || amount > 3)
{
 Console.WriteLine("Вы ввели не трехзначное число");
}
else
{
 Console.WriteLine(InCenter(number));
}
int ReadInt(string message)
{
 Console.Write(message);
 return Convert.ToInt32(Console.ReadLine());
}

int InCenter(int a)
{
    
 int result = ((a / 10) % 10);
 return result;
}
*/

//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели,
//и проверяет, является ли этот день выходным.

/*
Console.Write("enter a number from 1 to 7 : ");
int number = Convert.ToInt32(Console.ReadLine());

bool Сalendar(int number)
{
    return number >= 1 && number <= 5;
    
}
Console.WriteLine(Сalendar(number) ? "no" : "yes");
*/

// ПЕРЕПИСАТЬ ЭТАЛЛОННОЕ РЕШЕНИЕ