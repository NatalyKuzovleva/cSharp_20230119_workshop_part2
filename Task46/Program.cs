// Задача 46. Задайте двумерный массив размером m×n,
// заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1


// Что бы десятичная точка была вместо десятичной запятой
//System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

/************************* М Е Т О Д Ы *************************/

// Создание двумерного массива, заполненного псевдослучайными числами
int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns]; // создаём двумерный массив
    Random rnd = new Random(); // создаём экземпляр класса Рандом

    for (int i = 0; i < matrix.GetLength(0); i++) // matrix.GetLength(0) - нулевое измерение это строки
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
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


/***************************************************************/
Console.Clear();
int[,] array2D = CreateMatrixRndInt(3, 4, -100, 100);
PrintMatrix(array2D);