// Задача 1. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

int Prompt(string message)
{
    System.Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

double[,] CreateArray(int rous, int colums)
{
    double[,] massiv = new double[rous, colums];
    Random rnd = new Random();
    for (int i = 0; i < massiv.GetLength(0); i++)
    {
        for (int j = 0; j < massiv.GetLength(1); j++)
        {
            massiv[i, j] = rnd.Next(-10, 11) + rnd.NextDouble();
        }
    }
    return massiv;
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]:f1}\t");
        }
        System.Console.WriteLine();
    }
}

int m = Prompt("Введите количество строк: ");
int n = Prompt("Введите количество столбцов: ");
double[,] mas = CreateArray(m, n);
PrintArray(mas);