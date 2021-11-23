int[,] matrix = new int[3, 4];

void PrintArray(int[,] matr)
{
    for(int i = 0; i < matr.GetLength(0); i++)
    {
        for(int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
    Console.WriteLine();
    }
}

int[,] CreateArray(int[,] m)
{
    for(int i = 0; i < m.GetLength(0); i++)
    {
        for(int j = 0; j < m.GetLength(1); j++)
        {
            m[i, j] = new Random().Next(1, 10);
        }
    }
    return m;
}

int[,] randomMatrix = CreateArray(matrix);
PrintArray(randomMatrix);

