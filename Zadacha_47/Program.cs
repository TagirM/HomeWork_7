/*Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9*/
int m = 3;
int n = 4;
double[,] GetArray()
{
    double[,] matrix = new double[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++)//строчки
    {
        for (int j = 0; j < matrix.GetLength(1); j++)// столбцы
        {
            matrix[i, j] = 10 * Math.Round(new Random().NextDouble(), 2);
        }
    }
    return matrix;
}
double[,] resultMatrix = GetArray();
PrintArray(resultMatrix);

void PrintArray(double[,] inputMatrix)
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
