/*// Напишите программу, которая принимает на вход число (А)
//  и выдаёт сумму чисел от 1 до А.
int CountSum(int number)
{
    int resultSum = 0;
    for (int i = 1; i <= number; i++)
    {
        resultSum += i;
    }

    return resultSum;
}
Console.WriteLine("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(CountSum(num));*/


// Напишите программу, которая принимает на вход 
//число и выдаёт количество цифр в числе.

// Напишите программу, которая принимает на вход 
//число N и выдаёт произведение чисел от 1 до N.

/*//заполнение и вывод массива

int[] CreateRandomArray(int size,int minValue, int maxValue)// метод заполнения массива случайными числами
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
    {
        array[i]= new Random().Next(minValue,maxValue +1);//1, чтобы включить верхнюю границу диапазона
    }
    return array;
}

void PrintArray(int[] array)// метод вывода  массива в консоль
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
        
    }
    Console.WriteLine();
}
Console.WriteLine("Input size array: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input min value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input max value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateRandomArray(size,min,max);

PrintArray(newArray);*/

/*// Задача 25: Напишите цикл, который принимает на вход два 
//числа (A и B) и возводит число A в натуральную степень B.(без mathpow)
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int PowNumber(int baseNum, int exponentNum)
{
    int resultNum = baseNum;
    
    for (int i = 1; i < exponentNum; i++)
    {
        resultNum *= baseNum;
    }
    return resultNum;        
}
Console.WriteLine("Input two numbers: ");
int baseNum = Convert.ToInt32(Console.ReadLine());
int exponentNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{baseNum} ** {exponentNum} = {PowNumber(baseNum, exponentNum)} ");
Console.WriteLine("-----------------------------------------");*/


/*// Задача 27: Напишите программу, которая принимает на вход 
//число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int SumDigitInNumber(int number)
{
    int count = 0;
    while (number > 0)
    {
        count += number % 10;
        number /= 10;
    }
    return count;
}
Console.WriteLine("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"The sum of digit in the number {num} = {SumDigitInNumber(num)}");*/


// Задача 29: Напишите программу, которая задаёт массив из 8 
//элементов и выводит их на экран.(создать метод, запрашивающий ввод эл-тов у пользователя)
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

/*int[] CreateArray(int size)
{
    int[] array = new int[size];
    Console.WriteLine($"Input {size} numbers: ");
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}
// int[] arrayEightElem = CreateArray(8);
// ShowArray(arrayEightElem);
ShowArray(CreateArray(8));*/

//сортировка массива выбором

void SelectionSort(int[] array)
{
for (int i = 0; i < array.Length - 1; i++)
{
int minPosition = i;
for (int j = i + 1; j < array.Length; j++)
{
if (array[j] < array[minPosition])
{
minPosition = j;
}
}
int temporary = array[i];
array[i] = array[minPosition];
array[minPosition] = temporary;
}
}
int[]arr = {5,4,7,8,4,5};
SelectionSort(arr);
