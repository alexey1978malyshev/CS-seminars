
// int[] CreateRandomArray(int size, int minValue, int maxValue)// метод заполнения массива случайными числами
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(minValue, maxValue + 1);//1, чтобы включить верхнюю границу диапазона
//     }
//     return array;
// }

// void PrintArray(int[] array)// метод вывода  массива в консоль
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");

//     }
//     Console.WriteLine();
// }

/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/
/*int[] CreateRandomArray(int size)// метод заполнения массива случайными числами
{
    int minValue = 100;
    int maxValue = 999;
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}
int CountEvenNumbers(int[] array)
{   int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}
Console.WriteLine("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] newArray = CreateRandomArray(size);
PrintArray(newArray);
int result = CountEvenNumbers(newArray);
Console.WriteLine($"The count of even-numbers in array is {result}");
*/


/*Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/
/*int[] CreateRandomArray(int size, int minValue, int maxValue)// метод заполнения массива случайными числами
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);//1, чтобы включить верхнюю границу диапазона
    }
    return array;
}

int SumOddElements(int[] array)
{
    int sumOddPosElem = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        sumOddPosElem += array[i];
    }
    return sumOddPosElem;
}
Console.WriteLine("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input min value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input max value: ");
int max = Convert.ToInt32(Console.ReadLine());
int[] newArray = CreateRandomArray(size, min, max);
PrintArray(newArray);
int result = SumOddElements(newArray);
Console.WriteLine($"The sum of odd-position-numbers in array is {result}");*/

/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным
 элементов массива.
 next
 nextdouble()-генерирует вещественную величину в диап от 0 до 1, т.е чтобы создать вещ.число -> next + nextdouble
[3 7 22 2 78] -> 76*/
/*double[] CreateDoubleRandomArray(int size, int minValue, int maxValue)// метод заполнения массива случайными числами
{
    double[] array = new double[size];
    for (int i = 0; i < size; i++)    
    {
        array[i] = Math.Round(new Random().Next(minValue, maxValue + 1) + new Random().NextDouble(), 2);
    }
    return array;
}
void PrintDoubleArray(double[] array)// метод вывода  массива в консоль
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");

    }
    Console.WriteLine();
}

double CalkDiffMinMax(double[] array)
{
    
    int min = 0;
    int max = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > array[max]) max = i;
        else if (array[i] < array[min]) min = i;
    }
    double difference = array[max] - array[min];
    return difference;
}
Console.WriteLine("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input min value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input max value: ");
int max = Convert.ToInt32(Console.ReadLine());
double[] newArray = CreateDoubleRandomArray(size, min, max);
PrintDoubleArray(newArray);
double result = CalkDiffMinMax(newArray);
Console.WriteLine($"The difference of min and max values in array is {result}");*/




