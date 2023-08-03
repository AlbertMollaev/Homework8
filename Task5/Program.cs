// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

void DoSpiralMinmax(int rows, int cols)
{
    int[,] spiralArray = new int[rows, cols];
    int num = 1;
    int rowStart = 0, rowEnd = rows - 1;
    int colStart = 0, colEnd = cols - 1;

    while (num <= rows * cols)
    {
    for (int i = colStart; i <= colEnd; i++)
    {
        spiralArray[rowStart, i] = num++;
    }
    rowStart++;

    for (int i = rowStart; i <= rowEnd; i++)
    {
        spiralArray[i, colEnd] = num++;
    }
    colEnd--;

    if (rowStart <= rowEnd)
    {
        for (int i = colEnd; i >= colStart; i--)
        {
            spiralArray[rowEnd, i] = num++;
        }
        rowEnd--;
    }

    if (colStart <= colEnd)
    {
        for (int i = rowEnd; i >= rowStart; i--)
        {
            spiralArray[i, colStart] = num++;
        }
        colStart++;
    }
    }
    Console.WriteLine($"Сгенерирован массив [{rows}x{cols}] заполненный спирально !");
    Print2DMassiv(spiralArray);
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


int GetInput(string text)
{
        Console.Write(text);
        return Convert.ToInt32(Console.ReadLine());
}

int m = GetInput("Введите колличество строк массива: ");
int n = GetInput("Введите колличество столбцов массива: ");
DoSpiralMinmax(m,n);
