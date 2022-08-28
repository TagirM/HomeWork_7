/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет*/
int m = 3;
int n = 4;
int[,] GetArray()
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++)//строчки
    {
        for (int j = 0; j < matrix.GetLength(1); j++)// столбцы
        {
            matrix[i, j] = new Random().Next(-10, 11); 
        }
    }
    return matrix;
}
int[,] resultMatrix = GetArray(); 
PrintArray(resultMatrix);

void PrintArray(int[,] inputMatrix)
{
    for (int i = 0; i < inputMatrix.GetLength(0); i++) // строчки
    {
        for (int j = 0; j < inputMatrix.GetLength(1); j++) // столбцы
        {
            Console.Write(inputMatrix[i, j] + "\t"); //"\t" - Tab
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Введите позиции элемента в двумерном массиве: ");
int rows = Convert.ToInt32(Console.ReadLine());
int columns = Convert.ToInt32(Console.ReadLine());
if (rows<=m & columns<=n) Console.WriteLine($"Значение этого элемента {resultMatrix[rows, columns]}");
else Console.WriteLine("Такого элемента нет");

