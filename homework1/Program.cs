//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт,
//какое число большее, а какое меньшее.

/*
Console.Write("Input a first number: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int number2 = Convert.ToInt32(Console.ReadLine());
if(number1 > number2)
{
    Console.WriteLine("Самое большое число " + number1);
}
else
{
    Console.WriteLine("Самое большое число " + number2);
}
*/

//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

/*
Console.WriteLine("Введите 3 числа:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int num3 = Convert.ToInt32(Console.ReadLine());

            int max = num1;

            if (num2 > max)
            {
                max = num2;
            }

            if (num3 > max)
            {
                max = num3;
            }

            Console.WriteLine("Наибольшее из введённых чисел -> " + max);
*/

//Задача 6: Напишите программу, которая на вход принимает число и выдаёт,
//является ли число чётным (делится ли оно на два без остатка).

/*
Console.WriteLine("Введите число:");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num % 2 == 1)
            {
                Console.WriteLine("Число " + num + " нечетное");
            }
            else
            {
                Console.WriteLine("Число " + num + " четное");
            }
*/

//Задача 8: Напишите программу, которая на вход принимает число (N),
//а на выходе показывает все чётные числа от 1 до N.

/*
int count = 1;
            Console.WriteLine("Введите число:");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Чётные числа от 1 до " + number);
            while (count <= number)
            {
                if (count % 2 != 1)
                {
                    Console.Write(count + ". ");
                    
                }
                count++;
            }
*/          