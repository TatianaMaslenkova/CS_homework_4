// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
// Ограничения:
// - Должна быть отдельная функция, которая создаёт массив и отдельная функция вывода
// - Внутри функций (кроме функции вывода) НЕЛЬЗЯ использовать класс Console. Только в основном блоке 
// кода или в функции вывода

// 1-й способ (если генерировать случайным образом): 

Console.Clear();
int[] array = new int[8];
FillArray(array);
PrintArray(array);

void FillArray(int[] array)
{
    Random randGenegator = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = randGenegator.Next();
    }
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i == array.Length - 1)
            Console.WriteLine("]");
        else
            Console.Write(", ");
    }    
}

// 2-й способ (если задаёт пользователь): 
// Console.Write("Введите число 1: ");
// int a1 = int.Parse(Console.ReadLine()!);

// Console.Write("Введите число 2: ");
// int a2 = int.Parse(Console.ReadLine()!);

// Console.Write("Введите число 3: ");
// int a3 = int.Parse(Console.ReadLine()!);

// Console.Write("Введите число 4: ");
// int a4 = int.Parse(Console.ReadLine()!);

// Console.Write("Введите число 5: ");
// int a5 = int.Parse(Console.ReadLine()!);

// Console.Write("Введите число 6: ");
// int a6 = int.Parse(Console.ReadLine()!);

// Console.Write("Введите число 7: ");
// int a7 = int.Parse(Console.ReadLine()!);

// Console.Write("Введите число 8: ");
// int a8 = int.Parse(Console.ReadLine()!);

// int [] array = new int [8] {a1, a2, a3, a4, a5, a6, a7, a8};

// PrintArray(array);

// void PrintArray(int[] array)
// {
//     Console.Write("[");
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i]);
//         if (i == array.Length - 1)
//             Console.WriteLine("]");
//         else
//             Console.Write(", ");
//     }    
// }
