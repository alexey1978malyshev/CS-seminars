
int n = Convert.ToInt32(Console.ReadLine());
/*
int[,] multTable = new int[n,n];
int a = 1, b = 1;
for (int i = 0; i < multTable.GetLength(0); i++)
{
    for (int j = 0; j < multTable.GetLength(1); j++)
    {
        multTable[i,j] = a * b;
        b++;
    }
    b = 1;
    a++;    
}

for (int i = 0; i < multTable.GetLength(0); i++)
{
    for (int j = 0; j < multTable.GetLength(1); j++)
    {
        System.Console.Write(multTable[i,j] + " * ");
    }
    System.Console.WriteLine();
}

*/

for (int i = 1; i <= n; i++)
{
    for (int j = 1; j <= n; j++)
    {
        Console.Write(i * j);
        Console.Write("\t");
    }
    Console.WriteLine();
}

