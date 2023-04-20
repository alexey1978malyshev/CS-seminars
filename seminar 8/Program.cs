// Задайте двумерный массив. Напишите программу,
//  которая поменяет местами первую
//  и последнюю строку массива.

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

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");

        Console.WriteLine();
    }
    Console.WriteLine();
}
/*
void ChangeRows(int[,] array, int row1, int row2)
{
    if (row1 >= 0 && row1 < array.GetLength(0) && 
                row2 >= 0 && row2 < array.GetLength(0) && 
                row1 != row2)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int temp = array[row1, j];
            array[row1, j] = array[row2, j];
            array[row2, j] = temp;
        }
    }
    else System.Console.WriteLine("Wrong row numbers..");
}

int[,] newArray = CreateRandom2dArray();
Show2dArray(newArray);
Console.WriteLine(" Input  string numbers for change:");
int r1 = Convert.ToInt32(Console.ReadLine()) - 1;
int r2 = Convert.ToInt32(Console.ReadLine()) - 1;
ChangeRows(newArray, r1, r2);
Show2dArray(newArray);*/

// Задайте двумерный массив. Напишите программу, которая заменяет 
// строки на столбцы.

// Из двумерного массива целых чисел удалить строку и столбец, на пересечении
//  которых расположен наименьший элемент.