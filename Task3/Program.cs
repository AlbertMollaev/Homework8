// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] DivMatrix(int[,] massiv, int[,] massiv2)
{
    var massiv3 = new int[massiv.GetLength(0), massiv2.GetLength(1)];
    if (massiv.GetLength(1) == massiv2.GetLength(0))
    {
        for (int i = 0; i < massiv3.GetLength(0); i++)
        {
            for (int j = 0; j < massiv3.GetLength(1); j++)
            {
                massiv3[i, j] = 0;
                for (int n = 0; n < massiv.GetLength(1); n++)
                {
                    massiv3[i, j] += massiv[i, n] * massiv2[n, j];
                }
            }
        }
    }
    return massiv3;
}


void PrintSecond2Dmassiv(int[,] massiv)
{
    for (int i = 0; i < massiv.GetLength(0); i++)
    {
        for (int j = 0; j < massiv.GetLength(1); j++)
        {
            Console.Write($"{massiv[i,j]}\t");
        }
        Console.WriteLine();
    }
}

void Print2DMassiv(int[,] massiv)
{
    for (int i = 0; i < massiv.GetLength(0); i++)
    {
        for (int j = 0; j < massiv.GetLength(1); j++)
        {
            Console.Write($"{massiv[i,j]}\t");
        }
        Console.WriteLine();
    }
}

int[,] Generate2DMassive(int rows, int columns, int startValue, int finishValue)
{
    int[,] matrix = new int[rows,columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(startValue, finishValue + 1);
        }
    }
    return matrix;
}


int GetInput(string text)
{
        Console.Write(text);
        return Convert.ToInt32(Console.ReadLine());
}

int m = GetInput("Введите колличество строк массива: ");
int n = GetInput("Введите колличество столбцов массива: ");
int [,] massiv = Generate2DMassive(m, n, 2 , 4);
int [,] massiv2 = Generate2DMassive(m, n, 2 , 4);
Print2DMassiv(massiv);
Console.WriteLine(" ");
PrintSecond2Dmassiv(massiv2);
Console.WriteLine("Произведение двух массивов равно:  ");
Print2DMassiv(DivMatrix(massiv,massiv2));
