/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов 
в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] GetArray(int m, int n)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++)//строчки
    {
        for (int j = 0; j < matrix.GetLength(1); j++)// столбцы
        {
            matrix[i, j] = new Random().Next(11);
        }
    }
    return matrix;
}

int[,] resultMatrix = GetArray(rows, columns);
PrintArray(resultMatrix);

void PrintArray(int[,] inputMatrix)
{
    for (int i = 0; i < inputMatrix.GetLength(0); i++) // строчки
    {
        for (int m = 0; m < inputMatrix.GetLength(1); m++) // столбцы
        {
            Console.Write(inputMatrix[i, m] + "\t"); //"\t" - Tab
        }
        Console.WriteLine();
    }
}
int[] sumColumns = new int[columns];
for (int i = 0; i < resultMatrix.GetLength(0); i++)// строчки
{
    for (int j = 0; j < resultMatrix.GetLength(1); j++)// столбцы
    {
        sumColumns[j] = sumColumns[j] + resultMatrix[i, j];
    }
}
for (int n = 0; n < columns; n++) sumColumns[n] = sumColumns[n]/rows;

Console.WriteLine($"Cреднее арифметическое элементов в каждом столбце {string.Join(" ,", sumColumns)}");