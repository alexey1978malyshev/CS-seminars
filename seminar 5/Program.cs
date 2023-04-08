//Задайте массив из 12 элементов, 
//заполненный случайными числами из 
//промежутка [-9, 9]. Найдите сумму 
//отрицательных элементов массива.

/*int[] CreateRandomArray(int size,int minValue, int maxValue)// метод заполнения массива случайными числами
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

int GetNegativeSum(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0)
        {
            result += array[i];
        }        
    }
    return result;
}

int[] newArray = CreateRandomArray(12,-9,9);
PrintArray(newArray);
int resultSum = GetNegativeSum(newArray);
Console.WriteLine($"The sum of negative numbers is {resultSum}");*/


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


/*Напишите программу замена элементов массива: положительные элементы замените на 
соответствующие отрицательные, и наоборот.*/

/*int[] InverseNumbers(int[] array)
{
    int[] newArray = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
     newArray[i] *= -1;
    return newArray;
}
Console.WriteLine("Input size array: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input min value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input max value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] array = CreateRandomArray(size, min, max);
PrintArray(array);
int[]newArray  =InverseNumbers(array);
PrintArray(newArray);*/



/*Напишите программу, которая определяет, присутствует ли заданное число в массиве.*/

/*bool CheckNumberInArray(int[] array, int checkNumber)
{
    
    if (array.Contains(checkNumber)) return true;
    else return false;

}
Console.WriteLine("Input size array: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input min value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input max value: ");
int max = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number for check: ");
int checkNum = Convert.ToInt32(Console.ReadLine());
int[] array = CreateRandomArray(size, min, max);
PrintArray(array);
Console.WriteLine(CheckNumberInArray(array, checkNum));*/




/*Задайте одномерный массив из m случайных чисел. Найдите количество элементов массива, 
значения которых лежат в отрезке [a,b].*/

/*int CountElemInSlice(int[]array, int startValue, int finishValue)
{
    int countElem = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]>= startValue && array[i] <= finishValue)
        {
            countElem++; 
        }
                    
    }
    return countElem;
}*/
/*int[] CreateRandomArray(int size,int minValue, int maxValue)// метод заполнения массива случайными числами
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
}*/

/*Console.WriteLine("Input size array: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input min value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input max value: ");
int max = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input values a, b: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateRandomArray(m,min,max);

PrintArray(newArray);

int result = CountElemInSlice(newArray, a, b);
Console.WriteLine($"The count of numbers between {a} and {b} = {result}");*/


//Найти произведение пар чисел в массиве. Рез-т записать в новый массив
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

// int[] CoupleMultArray(int[] array)
// {
//     int[] newArray = new int[array.Length / 2];
//     for (int i = 0; i < newArray.Length; i++)
//     {
//         newArray[i] = array[i] * array[array.Length-1-i];
//     }
//     return newArray;
// }
// Console.WriteLine("Input size array: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input min value: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input max value: ");
// int max = Convert.ToInt32(Console.ReadLine());
// int[] array = CreateRandomArray(size, min, max);
// PrintArray(array);
// int[] newArray = CoupleMultArray(array);
// PrintArray(newArray);


