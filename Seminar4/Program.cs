//Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
//7 -> 28
//4 -> 10
//8 -> 36

/*
int Sum(int A)
{
    int sum = 0;
    for(int i=1; i<=A; i++)
    {
        sum+=i;
    }
    return sum;
}

System.Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
int sum = Sum(number);
Console.WriteLine($"Сумма от 1 до {number} = {sum}");
*/

//Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
//456 -> 3
//78 -> 2
//89126 -> 5

/*
int FiguresQuantity(int num)
{
    int length = 0;
    while (num % 10 !=0)
    {
        num /=10;
        length++;
    }
    return length;
}
System.Console.WriteLine("Введите число:");       // number != 0   не равен нулю  == равно нулю
int num = Convert.ToInt32(Console.ReadLine());      //  вместо int можно long длиннее число ToInt64 
Console.WriteLine($"число цифр {FiguresQuantity(num)}");  //Math.Abs(Convert.ToInt32(Console.ReadLine())) - модуль числа
*/

//Второй вариант
/*
System.Console.WriteLine("Введите число: ");
string str = Console.ReadLine();
if(int.TryParse(str, out int number))
{
if(str[0] == '-') // str.Contains("-") // number < 0
{
Console.WriteLine($"Цифр в нашем числе {number} = {str.Length - 1}");
}
else
{
Console.WriteLine($"Цифр в нашем числе {number} = {str.Length}");
}

}
else
{
System.Console.WriteLine("Ошибка");
}

*/

//Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
//4 -> 24 
//5 -> 120

/*
int MultiN(int num)

{
   int multy = 1;
   for(int i = 1; i <= num; i++)
   {
    multy = multy*i;
   }
   return multy;
}
System.Console.WriteLine("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());   
Console.WriteLine($"произведение {MultiN(num)}"); 
*/

// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

/*
int[] FillArray(int size)
{
int[] arr = new int[size];
Random rnd = new Random();
for(int i = 0; i < arr.Length; i++)
{
arr[i] = rnd.Next(0, 2);
}
return arr;
}

System.Console.Write("Введите кол-во элементов массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = FillArray(size);
System.Console.WriteLine($"[{string.Join(", ", array)}]");
*/