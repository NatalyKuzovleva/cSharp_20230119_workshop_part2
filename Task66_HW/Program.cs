// Задача 66. Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке 
// от M до N. Выполнить с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30


/************************* М Е Т О Д Ы *************************/

// Метод выводит в консоль текст на запрос ввода числа от пользователя
int EnterNumberRequest(string text)
{
    Console.WriteLine(text);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

// Метод выводит сумму натуральных элементов в промежутке от M до N
int SumNaturalNumbers(int m, int n)
{
    if (m == n) return m;
    else
    {
        if (m < n) return m + SumNaturalNumbers(m + 1, n);
        else return n + SumNaturalNumbers(m, n + 1);
    }
}


/***************************************************************/
Console.Clear();
int numM = EnterNumberRequest("Введите первое натуральное число M: ");
int numN = EnterNumberRequest("Введите второе натуральное число N: ");

if (numM <= 0 || numN <= 0) Console.WriteLine("Введены не натуральные числа. Проверьте данные!");
else
{
    int sumNaturalNumbers = SumNaturalNumbers(numM, numN);
    Console.Write($"M = {numM}; N = {numN} -> {sumNaturalNumbers}");
}
