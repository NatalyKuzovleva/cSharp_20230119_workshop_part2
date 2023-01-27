// Задача 42. Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10


/************************* М Е Т О Д Ы *************************/

// Метод выводит в консоль текст на запрос ввода числа от пользователя
int EnterNumberRequest(string text)
{
    Console.WriteLine(text);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}


// Метод преобразовывает десятичное число в двоичное
// Вариант 1. Через цикл while
// string ConvertDecToBin(int num)
// {
//     string result = string.Empty;   // создаём переменную для строки и объявляем её пустой, 
//                                     // как в случае с переменной для числа - кладём туда ноль
//     while (num > 0)
//     {
//         result = num % 2 + result;
//         num /= 2;       // num = num/2;
//     }
//     return result;
// }


// Метод преобразовывает десятичное число в двоичное
// Вариант 2. Через рекурсию

int ConvertDecToBin(int num)
{
    if (num ==0) return 0;
    int result = num % 2;
    num /= 2;
    result += ConvertDecToBin(num) *10;
    return result;
}

/***************************************************************/

int number = EnterNumberRequest("Введите десятичное число: ");
//string bin = ConvertDecToBin(number);

int bin = ConvertDecToBin(number);
Console.WriteLine($"{number} -> {bin}");

// Console.WriteLine(ConvertDecToBin(2));
// Console.WriteLine(ConvertDecToBin(number));

// Console.WriteLine(ConvertDecToBin(Convert.ToInt32(2)));
// Console.WriteLine(ConvertDecToBin(Convert.ToInt32(number)));