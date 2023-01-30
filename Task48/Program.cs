// Задача 48. Задайте двумерный массив размера m на n,
// каждый элемент в массиве находится по формуле: Amn = m+n.
// Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5


/************************* М Е Т О Д Ы *************************/

// Создание двумерного массива m на n, каждый элемент в массиве находится по формуле: Amn = m+n
int[,] CreateMatrixInt(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];     // создаём двумерный массив

    for (int i = 0; i < matrix.GetLength(0); i++)       // matrix.GetLength(0) - нулевое измерение это строки
    {
        for (int j = 0; j < matrix.GetLength(1); j++)   // matrix.GetLength(1) - первое измерение это столбцы
        {
            matrix[i, j] = i + j;
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

/***************************************************************/
Console.Clear();
int[,] array2D = CreateMatrixInt(3, 4);
PrintMatrix(array2D);