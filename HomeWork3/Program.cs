// Задача 3. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


int[,] CreateArray(int rous, int colums)
{
    int[,] massiv = new int[rous, colums];
    Random rnd = new Random();
    for (int i = 0; i < massiv.GetLength(0); i++)
    {
        for (int j = 0; j < massiv.GetLength(1); j++)
        {
            massiv[i, j] = rnd.Next(0, 11);
        }
    }
    return massiv;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]}\t");
        }
        System.Console.WriteLine();
    }
}

void SredneeArifm(int[,] array)
{
    double sredArifm = 0;
    double sum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        sredArifm = 0;
        sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum = sum + array[i, j];
        }
        sredArifm = sum / array.GetLength(0);
        System.Console.Write($"{sredArifm:f1}\t");
    }
}


int[,] mas = CreateArray(3, 3);
PrintArray(mas);
System.Console.WriteLine();
SredneeArifm(mas);
