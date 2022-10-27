// Задача 2. Напишите программу, которая на вход принимает позиции элемента 
// в двумерном массиве, и возвращает значение этого элемента или же указание,
//  что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого числа в массиве нет

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

double FindPosition(double[,] array, int row, int column)
{
    if (row < 0 | row > array.GetLength(0) - 1 | column < 0 | column > array.GetLength(1) - 1)
    {
        System.Console.WriteLine("Такого элемента не существует.");
    }
    else
    {
        System.Console.WriteLine($"{array[row, column]:f1}");
    }
    return array[row, column];
}

int m = Prompt("Введите количество строк: ");
int n = Prompt("Введите количество столбцов: ");
double[,] mas = CreateArray(m, n);
PrintArray(mas);
System.Console.WriteLine();
int row = Prompt("Введите номер искомой строки: ");
int column = Prompt("Введите номер искомого столбца: ");
System.Console.WriteLine();
FindPosition(mas, row, column);
