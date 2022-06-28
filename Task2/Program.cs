// Задача 2: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение 
//этого элемента или же указание, что такого элемента нет.

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

int FindElement(int row, int column, int[,] array)
{
   	if(row >= array.GetLength(0) || column >= array.GetLength(1) || row < 1 || column < 1) 
	{
		Console.WriteLine("Такого элемента нет");
        Environment.Exit(0);
	}
    int findingElement = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    { 
        for (int j = 0; j < array.GetLength(1); j++)
        {
           if(i == row && j == column) 
           {
             findingElement = array[i,j];                   
           }
           
       }
    }
    return findingElement;
}

int row = Prompt("Введите количество строк > ");
int column = Prompt("Введите количество столбцов > ");
int min = -10;
int max = 10;
int[,] array = GenerateArray(row, column, min, max);
PrintArray(array);
int findingRow = Prompt("Введите строку для поиска => ");
int findingColumn = Prompt("Введите столбец для поиска => ");
var resault = FindElement((findingRow-1), (findingColumn - 1), array);
System.Console.WriteLine($"Элемент массива по координатам [{findingRow}, {findingColumn}] равен {resault}.");
