// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// Чтобы десятичная точка была вместо десятичной запятой
System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");


/************************* М Е Т О Д Ы *************************/

// Создание двумерного массива, заполненного псевдослучайными числами
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


// Вывод двумерного числового массива в консоль
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4}");
            else Console.Write($"{matrix[i, j],4}  ");
        }
        Console.WriteLine("|");
    }
}


// Поиск среднего арифметического элементов в каждом столбце.
double[] FindArithmeticMean(int[,] matrix)
{
    double[] array = new double[matrix.GetLength(1)];
    for (int j = 0; j < matrix.GetLength(1); j++)
    { 
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            array[j] += matrix[i, j];
        }
        array[j] /= matrix.GetLength(0);
        array[j] = Math.Round(array[j], 1, MidpointRounding.AwayFromZero);
            // Округляем до 1 знака после запятой
            /* MidpointRounding.AwayFromZero - Стратегия округления до ближайшего числа, и когда число находится 
            на полпути между двумя другими, оно округляется в сторону ближайшего числа, которое от нуля.*/
    }
    return array;
}


// Вывод массива на печать в строку в формате (a1,a2,a3,a4,a5)
void PrintArrayDouble(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
            Console.Write(array[i] + "; ");
        else
            Console.Write(array[i]);
    }
}

/***************************************************************/
Console.Clear();
int[,] array2D = CreateMatrixRndInt(5, 6, 1, 9);
PrintMatrix(array2D);

double[] arrArithmeticMean = FindArithmeticMean(array2D);
Console.Write("Среднее арифметическое каждого столбца: ");
PrintArrayDouble(arrArithmeticMean);