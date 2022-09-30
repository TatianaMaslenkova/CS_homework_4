// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A 
// в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
// Ограничения:
// - Нельзя использовать класс Math
// - Должна быть отдельная функция Power, которая возвращает результат
// - Внутри функций НЕЛЬЗЯ использовать класс Console. Только в основном блоке кода

Console.Clear();

Console.Write("Введите число A: ");
double a = double.Parse(Console.ReadLine()!);

Console.Write("Введите натуральное число B: ");
int b = int.Parse(Console.ReadLine()!);

double result = 1;
if(b <= 0)
{
    Console.WriteLine("Введите натуральное число B!");
}
else if(b == 1)
{
    Console.WriteLine($"Результат возведения A в степень B: {a}");
}

else
{
    Console.WriteLine($"Результат возведения A в степень B: {Power(result, a, b)}");
}

double Power(double result, double a, int b)
{
    for(int i = 1; i <= b; i++)
    {
        result = result * a;
    }
    return result;
}