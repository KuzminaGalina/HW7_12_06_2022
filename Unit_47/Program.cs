/*Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

int[,] FillArray(int row, int column)
{
    int[,] Array = new int[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            Array[i, j] = new Random().Next(1, 10);
        }
    }
    return Array;
}

void PrintArray(int[,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)

    {

        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Console.Write($"{Array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int row = 3;
int column = 4;
int[,] NewArray = FillArray(row, column);
PrintArray(NewArray);