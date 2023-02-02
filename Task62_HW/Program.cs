// *Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.

// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


/**********************  МЕТОДЫ  **********************/

// Метод на запрос ввода числа от пользователя
int EnterNumberRequest(string text)
{
    Console.Write(text);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}


// Метод спирального заполнения массива
void FillSpiralArray(int[,] array)
{
    int i = 0, j = 0;
    int value = 1;
    int s = array.GetLength(0);
    for (int e = 0; e < s * s; e++)
    {
        int k = 0;
        do { array[i, j++] = value++; }
        while (++k < s - 1);
        for (k = 0; k < s - 1; k++)
        {
            array[i++, j] = value++;
        }
        for (k = 0; k < s - 1; k++)
        {
            array[i, j--] = value++;
        }
        for (k = 0; k < s - 1; k++)
        {
            array[i--, j] = value++;
        }
        ++i; ++j;
        s = s < 2 ? 0 : s - 2;
    }
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
            else Console.Write($"{matrix[i, j],4}  ");
        }
        Console.WriteLine("|");
    }
}


/*********************************************************************************/
Console.Clear();
int size = EnterNumberRequest("Введите размерность массива: ");

int[,] array2D = new int[size, size];       // создаём квадратный массив
FillSpiralArray(array2D);
PrintMatrix(array2D);