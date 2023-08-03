// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


void Print2DMassiv(int[,,] massiv)
{
    for (int i = 0; i < massiv.GetLength(0); i++)
    {
        for (int j = 0; j < massiv.GetLength(1); j++)
        {
            for (int k = 0; k < massiv.GetLength(1); k++)
            {
            Console.Write($"{massiv[i,j,0]} ({i},{j},{k}) \t");
            }
        }
        Console.WriteLine();
    }
}

int[,,] Generate2DMassive(int rows, int columns,int deep, int startValue, int finishValue)
{
    int[,,] matrix = new int[rows,columns,deep];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(1); k++)
            {
               matrix[i,j,k] = new Random().Next(startValue, finishValue + 1); 
            }
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
int k = GetInput("Введите третий слой массива: ");
int [,,] massiv = Generate2DMassive(m, n, k, 01 , 09);
Print2DMassiv(massiv);