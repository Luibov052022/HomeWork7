// Задача 3: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.


int Prompt(string message){
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int[,] GenerateArray(int row, int column, int min, int max)
{
    var array = new int[row, column];
    var rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(min, max + 1);
        }
    }

    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}
double AverageOfColumn(int column, int[,] array)
{
double sum = 0;
int row = array.GetLength(0); 
for(int i = 0; i < row; i++)
	{
		sum += array[i, column];
	}
sum = sum/row;
return sum;
}

int row = Prompt("Введите количество строк > ");
int column = Prompt("Введите количество столбцов > ");
int min = -10;
int max = 10;
int[,] array = GenerateArray(row, column, min, max);
PrintArray(array);

for(int i = 0; i < column; i++)
{
	Console.WriteLine($"Среднее арифметическое элементов столбца {i+1} равно {AverageOfColumn(i, array):f2}");
}
