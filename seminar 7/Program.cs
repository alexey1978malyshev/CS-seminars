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

