// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
Console.WriteLine("Доброго дня!");
Console.Write("Введите количество строк: ");
int rows;
while (!int.TryParse(Console.ReadLine(), out rows))
{
    Console.WriteLine("Ошибка ввода. Введите корректное количество строк: ");
}

Console.Write("Введите количество столбцов: ");
int cols;
while (!int.TryParse(Console.ReadLine(), out cols))
{
    Console.WriteLine("Ошибка ввода. Введите корректное количество столбцов: ");
}

Random random = new Random();
double[,] array = new double[rows, cols];

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < cols; j++)
    {
        array[i, j] = random.NextDouble() * 10;
    }
}

Console.WriteLine("Наш Массив: ");
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < cols; j++)
    {
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
    Console.WriteLine("Досвидания.");
}

