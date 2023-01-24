// Задача 39. Напишите программу, которая перевернёт
// одномерный массив (последний элемент будет на первом
// месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]


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

// Вывод массива на печать в строку в формате [a1,a2,a3,a4,a5]
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

// Метод переворачивает массив
void ReverseArray(int[] array)
{
    for (int i = 0; i < array.Length/2; i++)      // [1 2 3 4 5] -> [5 4 3 2 1]
    {
        int temp = array[i];
        array[i] = array[array.Length - 1 - i];
        array[array.Length-1-i] = temp;
    }
}

/***************************************************************/

int[] arr = CreateArrayRndInt(6, 0, 9);
PrintArray(arr);

// Array.Reverse(arr); // Встроенный метод класса Array, который переворачивает массив
// PrintArray(arr);

ReverseArray(arr);
PrintArray(arr);
