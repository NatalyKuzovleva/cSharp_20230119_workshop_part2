// Задача 65. Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"


/************************* М Е Т О Д Ы *************************/

// Метод выводит в консоль текст на запрос ввода числа от пользователя
int EnterNumberRequest(string text)
{
    Console.WriteLine(text);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}


// Метод выводит все натуральные числа в промежутке от M до N
// Вариант 1
void NaturalNumbers(int m, int n)
{
    if (m == n)
    {
        Console.Write($"{m} ");
        return;
    }
    Console.Write($"{m} ");
    if (m > n)
        NaturalNumbers(m - 1, n);
    else
        NaturalNumbers(m + 1, n);
}


// Метод выводит все натуральные числа в промежутке от N до 1
// Вариант 2
// void NaturalNumber(int num1, int num2)
// {
//     if (num == 0) return;
//     if (num > 1) Console.Write($"{num}, ");
//     else Console.Write($"{num}");
//     NaturalNumber(num - 1);
// }

/***************************************************************/
Console.Clear();
int numM = EnterNumberRequest("Введите первое натуральное число M: ");
int numN = EnterNumberRequest("Введите первое натуральное число N: ");

if (numM <= 0 && numN <= 0) Console.WriteLine("Введено не натуральное число. Проверьте данные!");
else
{
    Console.Write($"M = {numM}: N = {numN} -> \"");
    NaturalNumbers(numM, numN);
    Console.Write("\"");
}
