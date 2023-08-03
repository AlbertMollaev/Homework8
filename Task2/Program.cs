// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

void GetMinRowSum(int[,] array)
{
int minSum = 0;
int rowMinSum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        if (i == 0) minSum = sum;
        if (sum < minSum)
        {
            minSum = sum;
            rowMinSum = i;
        }
    }
    Console.Write($"Cтрока {rowMinSum + 1} содержит минимальную сумму элементов");
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
int [,] massiv = Generate2DMassive(m, n, 1 , 9);
Print2DMassiv(massiv);
GetMinRowSum(massiv);
