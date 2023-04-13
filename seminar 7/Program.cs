// Задайте двумерный массив размером m×n, 
// заполненный случайными целыми числами.

/*int[,] CreateRandom2dArray()
{
    Console.WriteLine("Input a quantity of rows:"); //включение строк запроса позволяет избавиться от аргументов в большом количестве
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input a quantity of columns:");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input min value:");
    int minVal = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input max value:");
    int maxVal = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);

    return array;
}*/
// void Show2dArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             Console.Write(array[i, j] + " ");

//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }




/*
Задайте двумерный массив размера m на n,
 каждый элемент в массиве находится по формуле:
  Aij = i+j. Выведите полученный массив на экран.
*/
// int[,] Array2d(int m, int n)
// {
//     int[,] array = new int[m, n];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = i + j;
//         }
//     }
//     return array;
// }
// void Show2dArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             Console.Write(array[i, j] + " ");

//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }


// Console.WriteLine("Input m:");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input n:");
// int n = Convert.ToInt32(Console.ReadLine());

// int[,] newArray = Array2d(m, n);
// Show2dArray(newArray);





/*
Задайте двумерный массив. Найдите элементы, у которых
 оба индекса чётные, и замените эти элементы на их квадраты.
*/
/*
int[,] CreateRandom2dArray()
{
    Console.WriteLine("Input a quantity of rows:"); //включение строк запроса позволяет избавиться от аргументов в большом количестве
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input a quantity of columns:");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input min value:");
    int minVal = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input max value:");
    int maxVal = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(minVal, maxVal + 1);

    return array;
}

void FindEvent(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0)
            {
                array[i,j]*= array[i,j];
            }
        }
    }
}
*/void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");

        Console.WriteLine();
    }
    Console.WriteLine();
}

// int[,] newArray = CreateRandom2dArray();
// Show2dArray(newArray);
// FindEvent(newArray);
// Show2dArray(newArray);



// /*
// Задайте двумерный массив. Найдите сумму элементов, находящихся 
// на главной диагонали (с индексами (0,0); (1;1) и т.д.
// */

int[,] Array2d()
{
    Console.WriteLine("Input a quantity of rows:"); 
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input a quantity of columns:");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input min value:");
    int minVal = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input max value:");
    int maxVal = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(minVal, maxVal + 1);

    return array;
}

int FindDiagSum(int[,] array)
{
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == j)
            {
                sum += array[i,j];
            }
        }
    }
    

    return sum;
}

int[,] newArr = Array2d();
Show2dArray(newArr);
Console.WriteLine(FindDiagSum(newArr));  

/*
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9

Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
 и возвращает значение этого элемента или же указание, что такого элемента нет.
(void)
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
1 7 -> такого числа в массиве нет

Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце. 
пройтись по столбцам, сложить и поделить..(рез-т - одномереный массив)
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

*/