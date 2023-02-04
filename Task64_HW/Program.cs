// Задача 64. Задайте значение N. 
// Напишите программу, которая выведет все натуральные числа 
// в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


/************************* М Е Т О Д Ы *************************/

// Метод выводит в консоль текст на запрос ввода числа от пользователя
int EnterNumberRequest(string text)
{
    Console.WriteLine(text);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}


// Метод выводит все натуральные числа в промежутке от N до 1
void NaturalNumber(int num)
{
    if (num == 0) return;
    if (num > 1) Console.Write($"{num}, ");
    else Console.Write($"{num}");
    NaturalNumber(num - 1);
}

/***************************************************************/
Console.Clear();
int number = EnterNumberRequest("Введите натуральное число: ");
if (number <= 0) Console.WriteLine("Введено не натуральное число. Проверьте данные!");
else
{
    Console.Write($"N = {number} -> \"");
    NaturalNumber(number);
    Console.Write("\"");
}
