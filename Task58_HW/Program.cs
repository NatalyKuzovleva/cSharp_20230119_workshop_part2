// Задача 58. Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц.

// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


/************************* М Е Т О Д Ы *************************/

// Создание двумерного массива, заполненного псевдослучайными целыми числами
int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];     // создаём двумерный массив
    Random rnd = new Random();                  // создаём экземпляр класса Рандом

    for (int i = 0; i < matrix.GetLength(0); i++)       // matrix.GetLength(0) - нулевое измерение это строки
    {
        for (int j = 0; j < matrix.GetLength(1); j++)   // matrix.GetLength(1) - первое измерение это столбцы
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}


// Вывод двумерного числового массива на печать в консоль
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4}");
            else Console.Write($"{matrix[i, j],4}   ");
        }
        Console.WriteLine("|");
    }
}

// Метод перемножает две матрицы
int[,] MultiplyArrays(int[,] array1, int[,] array2)
{
    int[,] array = new int[array1.GetLength(0), array2.GetLength(1)];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array1.GetLength(1); k++)
            {
                array[i, j] += array1[i, k] * array2[k, j];
            }
        }
    }
    return array;
}

/***************************************************************/
Console.Clear();
int[,] firstArray2D = CreateMatrixRndInt(3, 4, 0, 9);
int[,] secondArray2D = CreateMatrixRndInt(2, 5, 0, 9);
Console.WriteLine("Матрица A:");
PrintMatrix(firstArray2D);
Console.WriteLine();
Console.WriteLine("Матрица B:");
PrintMatrix(secondArray2D);
Console.WriteLine();

// Умножать матрицы можно тогда и только тогда, когда количество 
// столбцов первой матрицы равно количеству строк второй матрицы.
if (firstArray2D.GetLength(1) == secondArray2D.GetLength(0))
{
    int[,] resultMatrix = MultiplyArrays(firstArray2D, secondArray2D);
    Console.WriteLine("Произведение двух матриц:");
    PrintMatrix(resultMatrix);
}
else Console.WriteLine("Данные матрицы перемножать нельзя!");