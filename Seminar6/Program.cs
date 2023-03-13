//Задача 39: Напишите программу, которая перевернёт одномерный массив
//(последний элемент будет на первом месте, а первый - на последнем и т.д.)
//[1 2 3 4 5] -> [5 4 3 2 1]
//[6 7 3 6] -> [6 3 7 6]

/*
int[] FillArrayWhithRandomNumber(int size)
{
int[] arr = new int[size];
Random rnd = new Random();
for(int i = 0; i < arr.Length; i++)
{
arr[i] = rnd.Next(-9, 10);
}
return arr;
}

void ReverseArray(int[] arr)
{
int temp = 0;

for(int i = 0; i < arr.Length/2; i++)
{
    temp = arr[i];
    arr[i] = arr[arr.Length - 1 - i];
    arr[arr.Length - 1 - i] = temp;
}
}

System.Console.Write("Введите длину массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = FillArrayWhithRandomNumber(size);
System.Console.WriteLine($"[{string.Join(", ", array)}]");
ReverseArray(array);
System.Console.WriteLine($"[{string.Join(", ", array)}]"); 
*/

//Задача 40: Напишите программу, которая принимает на вход три числа и проверяет,
//может ли существовать треугольник со сторонами такой длины.
//Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

/*
System.Console.Write("Введите первую сторону треугольника: ");
int AB = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите вторую сторону треугольника: ");
int BC = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите третью сторону треугольника: ");
int AC = Convert.ToInt32(Console.ReadLine());

if(AB + BC > AC && AB + AC > BC && BC + AC > AB)
{
System.Console.Write("Треугольник существует");
}
else
{
System.Console.Write("Треугольник не существует");
}

*/

//Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
//45 -> 101101
//3  -> 11
//2  -> 10


// Через РЕКУРСИЮ

/*
void PrintBinary(int number)
{
if(number <= 0)
{
return;
}

PrintBinary(number/2);
Console.Write(number%2);
}

System.Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
PrintBinary(number);
*/

//  Через алгоритм 

/*
Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
int end = 0;
int d = 1;
while (num1 > 0)
{
end = end + num1 % 2*d;
num1 /= 2;
d*=10;
Console.Write(end);
}

*/

// Через строку без разворота 
/* 
Console.Write("Number = "); 
int n = int.Parse(Console.ReadLine()); 
string counter = ""; 

while (n >= 1) 
{ 
    counter = (n % 2) + counter; 
    n = n/2; 
} 
Console.Write(counter); 
*/

// Через массив 

/*
int SizeofDif(int num)
{
int count = 0;

while (num > 0)
{
    num /= 2;
    count++;
}

return count;
}

int[] Dif(int num)
{
int[] arr = new int[SizeofDif(num)];

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = num % 2;
    num /= 2;
}

return arr;
}

int[] Reverse(int[] someArr)
{

for (int i = 0; i < someArr.Length/2; i++)
{
    int temp = someArr[i];
    someArr[i] = someArr[someArr.Length - 1 - i];
    someArr[someArr.Length - 1 - i] = temp;
}

return someArr;
}

int[] result = Dif(2);
Console.WriteLine($"Your array: [{string.Join(", ", result)}]");
int[] newArr = Reverse(result);
Console.WriteLine($"Reverse array: [{string.Join(", ", newArr)}]");
*/


//Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
//Если N = 5 -> 0 1 1 2 3
//Если N = 3 -> 0 1 1
//Если N = 7 -> 0 1 1 2 3 5 8

// цикл
/*
void PrintFibToN(int N)
{
int fib1 = 0;
int fib2 = 1;
int fib3 = 0;
Console.Write("0 1 ");
for(int i = 0; i < N - 2; i++)
{
fib3 = fib1 + fib2;
Console.Write($"{fib3} ");
fib1 = fib2;
fib2 = fib3;
}
}

System.Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
PrintFibToN(number);
*/


//Второй вариант решения массив
/*
Console.Write("Input number ");
int number = Convert.ToInt32(Console.ReadLine());
int[] array = new int[number];
array[0] = 0;
array[1] = 1;
for(int i = 2; i < number; i++){
array[i] = array[i-2] + array[i-1];
}
Console.Write("Array: ");
Console.WriteLine($"[{string.Join(", ", array)}]");
*/

//Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

/*

int[] FillArrayWhithRandomNumber(int size)
{
int[] arr = new int[size];
Random rnd = new Random();
for(int i = 0; i < arr.Length; i++)
{
arr[i] = rnd.Next(-9, 10);
}
return arr;
}

int[] CopyArray(int[] arr, int size)
{
int[] copyArr = new int[size];
for(int i = 0; i < copyArr.Length; i++)
{
copyArr[i] = arr[i];
}
return copyArr;
}

System.Console.Write("Введите длину массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = FillArrayWhithRandomNumber(size);
int[] changeArray = CopyArray(array, size);

System.Console.WriteLine($"[{string.Join(", ", array)}]");
System.Console.WriteLine($"[{string.Join(", ", changeArray)}]");
*/

 //41 задача
/*
int[] FillArray(int size)
{
int[] arr = new int[size];

for(int i = 0; i < arr.Length; i++)
{
    Console.Write($"Input arr{i}: ");
    arr[i] = Convert.ToInt32(Console.ReadLine());
}
return arr;
}
*/