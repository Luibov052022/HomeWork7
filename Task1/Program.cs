// Задача 1: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

int Prompt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

double[,] GenerateArray(int row, int column)
{
    var array = new double[row, column];
    var rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.NextDouble()*1000;
        }
    }

    return array;
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]:f2}" + "\t");
        }
        System.Console.WriteLine();
    }
}

int row = Prompt("Введите количество строк > ");
int column = Prompt("Введите количество столбцов > ");
double[,] array = GenerateArray(row, column);
PrintArray(array);
