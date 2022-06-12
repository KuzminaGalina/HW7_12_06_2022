/*Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
5 -> 9
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



int FindNumber(int[,] Array, int NumberPosition)
{
    while (NumberPosition > Array.GetLength(0) * Array.GetLength(1) - 1)
    {
        Console.WriteLine($"Такого числа нет. Введите число меньше {Array.GetLength(0) * Array.GetLength(1)}");
        NumberPosition = Convert.ToInt32(Console.ReadLine());
    }

    int row = NumberPosition / Array.GetLength(1);
    int column = NumberPosition % Array.GetLength(1);
    return Array[row, column];

}


int row = 3;
int column = 4;
int[,] NewArray = FillArray(row, column);
PrintArray(NewArray);

Console.WriteLine("Введите номер элемента массива: ");
int count = Convert.ToInt32(Console.ReadLine());
int result = FindNumber(NewArray, count);
Console.WriteLine($"Задуманное число -  {result}");


