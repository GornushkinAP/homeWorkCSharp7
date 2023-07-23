// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

void FillArray(double[,] array2mer)
{
    for (double i = 0; i < array2mer.GetLength(0); i++)
{
    for (double j = 0; j < array2mer.GetLength(1); j++)
    {
        array2mer[i, j] = new Random().NextDouble(10, 10);
    }
}
}

void PrintArray(double[,] array2mer)
{
    for (double i = 0; i < array2mer.GetLength(0); i++)
    {
        for (double j = 0; j < array2mer.GetLength(1); j++)
        {
            Console.Write($"{array2mer[i, j]} ");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите количество строк: ");
double rows = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
double cols = Convert.ToDouble(Console.ReadLine());

double[,] matrix = new double[rows, cols];
for (double rows = 0; rows < matrix.GetLength(0); rows++)
{
    for (double cols = 0; cols < matrix.GetLength(1); cols++)
    {
        matrix[rows, cols] = new Random().NextDouble(rows, cols);
    }
    Console.WriteLine();
    Console.Write(matrix);
}

