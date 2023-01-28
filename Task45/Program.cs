// Задача 45. Напишите программу, которая будет создавать
// копию заданного массива с помощью поэлементного
// копирования.


/************************* М Е Т О Д Ы *************************/

// Создание массива, заполненного псевдослучайными числами
int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size]; // создаём массив
    Random rnd = new Random(); // создаём экземпляр класса Рандом

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}


// Вывод числового массива на печать в строку в формате [a1,a2,a3,a4,a5]
void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
            Console.Write(array[i] + ",");
        else
            Console.Write(array[i]);
    }
    Console.WriteLine("]");
}


int[] CopyArray(int[] array)
{
    int[] newArray = new int[array.Length];
    for (int i = 0; i < newArray.Length; i++)
    {
        newArray[i] = array[i];
    }
    return newArray;
}

/***************************************************************/

int[] arr = CreateArrayRndInt(5, 0, 9);
int[] newArr = CopyArray(arr);
newArr[0] = 55;  // для проверки в новый массив записали другое значение элемента
PrintArray(newArr);
Console.Write("Исходный массив -> ");
PrintArray(arr);
Console.Write("Скопированный массив -> ");
PrintArray(newArr);