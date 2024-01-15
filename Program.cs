// Напишите программу, которая на вход
// принимает два целых числа и проверяет,
// является ли первое число квадратом второго.
// a = 25, b = 5 => да
// a = 2, b = 10 => нет
// a = 9, b = -3 => да
// a = -3, b = 9 => нет

// тип_данных имя_переменной = значение;
// camelCase: firstNumber, secondNumber
// int number = 9; // number = 9
// int result = number * number; // 81

// Console.ReadLine() - получить информацию из строчки
/* 
 */

// On Windows: Shift + Alt + F
// On Mac: Shift + Option + F

// Напишите программу, которая на вход принимает
// целое число N, а на выходе показывает все целые
// числа в промежутке от -N до N.
// Примеры
// 4 => -4, -3, -2, -1, 0, 1, 2, 3, 4
// 2 => -2, -1, 0, 1, 2

Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
// N = 4,
int negativeN = N * -1; // -4

while (negativeN <= N)// -3 -2 -1 0 1 2 3
{
    Console.Write(negativeN + " ");
    negativeN++; // negativeN++ (negativeN = negativeN + 1)
}