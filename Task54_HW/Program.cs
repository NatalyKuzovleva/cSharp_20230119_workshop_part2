// Задача 54. Задайте двумерный массив. Напишите программу, которая упорядочит 
// по убыванию элементы каждой строки двумерного массива.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


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
            //if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],5},"); // в интерполяцию добавили форматирование
            // без разделительной запятой между элементами if-else не нужен! 
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],5}");
            else Console.Write($"{matrix[i, j],5}  ");
        }
        Console.WriteLine("|");
    }
}


// Метод сортирует по убыванию элементы каждой строки двумерного массива.
void SortRowsMaxToMin(int[,] matrix)
{
    int temp = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(1) - 1; k++)
            {
                if (matrix[i, k] < matrix[i, k + 1])
                {
                    temp = matrix[i, k + 1];
                    matrix[i, k + 1] = matrix[i, k];
                    matrix[i, k] = temp;
                }
            }
        }
    }
}

/***************************************************************/
Console.Clear();
int[,] array2D = CreateMatrixRndInt(3, 4, -15, 15);
PrintMatrix(array2D);
Console.WriteLine();
SortRowsMaxToMin(array2D);
PrintMatrix(array2D);