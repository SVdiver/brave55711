// Напишите программу, которая принимает на вход
// трёхзначное число и удаляет вторую цифру этого
// числа.
// Примеры
// a = 256 => 26
// a = 891 => 81

// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// // "&&" - "И": "&&" яблоки и апельсины (и то, и другое нужно купить)
// // "||" - "ИЛИ": яблоки ИЛИ апельсины (что-то одно, либо все вместе)
// if (number >= 100 && number <= 999) // Число - трехзначное
// {
//     int firstDigit = number  / 100; // 274 /100 = 2
//     int thirdDigit = number % 10;  // 274 % 10 = 4
//     int result = firstDigit * 10 + thirdDigit;
//     // Интерполяция: $"Значение переменной {thirdDigit}" = {}"
//     Console.WriteLine($"Результат от числа {number} = {result}");
// }
// else // Число НЕ трехзначное
// {
//      Console.WriteLine("Число НЕ трехзначное");
// }

// Напишите программу, которая принимает на вход трёхзначное
// число и возводит вторую цифру этого числа в степень, равную
// третьей цифре.
// Примеры
// 487 => 8^7 = 2 097 152
// 254 => 5^4 = 625
// // 617 => 1
// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number >= 100 && number <= 999) 
// {
//    int secondDigit = number / 10 % 10; // 487 / 10 % 10 = 48 % 10 = 8
//    int thirdDigit = number % 10;  // 487 % 10 = 7 
//    // Math.Pow(5, 2) => 5 в 2 степени
//    int result = (int)Math.Pow(secondDigit, thirdDigit);
//    Console.WriteLine($"Число {number}; {secondDigit}^{thirdDigit} = {result}");
// }
// else // число не трехзначное
// {
//     Console.WriteLine("Число не трехзначное");
// }

// Получите 3 цифру введенного числа слева (с начала)
// 1234567 => 3
// 7891 => 9
// 32 => 3 цифры нет

// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int copyNumber = number;
// if (number < 100) // Число не трехзначное
// {
//     Console.WriteLine("Третьей цифры нет :)");
// }
// else // Число трехзначное
// {
//     while(number > 999) // Если в числе минимум 4 цифры, я делю:)
//     {
//         number /= 10; 
//     }
//     Console.WriteLine($"Третья цифра от числа {copyNumber} = {number % 10}"); 
// }   

// "Привет" и "1234567"

// Введенная строчка состоит только из цифр (TryParse)


// Получи третью цифру справа
// 456 => 4
// 7812 => 8
// 91 => Третьей цифры нет

// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int copyNumber = number;
// if (number < 100) // Число не трехзначное
// {
//     Console.WriteLine("Третьей цифры нет :)");
// }    
// else // Число минимум трехзначное
// {
//     int digitCount = 0; // Количество цифр, которое нужно убрать
//     int digit = 0; // Третья цифра справа
//     while (digitCount < 2) // Отбросываем 2 последние цифры
//     {
//         number /=10;
//         digitCount++; // digitCount = digitCount + 1 
//     }
//    Console.WriteLine(number % 10); 
// }   
// int number = 123
// Console.Writeline(number / 100 % 10);

// TryParse

// ДЗ задача 1

// Console.Write("Введите число: ");
//  int number = Convert.ToInt32(Console.ReadLine()); 

// if (number % 7==0 && number % 23 == 0) 
// {
//     Console.WriteLine($"{number} Число кратно 7 и 23");       
// }
// else 
// {
//     Console.WriteLine($"{number} Число не кратно 7 и 23");
// }

// ДЗ Задача 2

//  Console.Write("Введите число x:");
//  int x = Convert.ToInt32(Console.ReadLine());
//  Console.Write("Введите число y:");
//  int y = Convert.ToInt32(Console.ReadLine());

//  if ( x > 0 && y > 0 )
//  {
//     Console.WriteLine("1 четверть");
//  }
//  if ( x < 0 && y > 0 )
//  {
//     Console.WriteLine("2 четверть");
//  }
//  if ( x < 0 && y < 0 )
//  {
//     Console.WriteLine("3 четверть");
//  }
//  if ( x > 0 && y < 0)
//  {
//     Console.WriteLine("4 четверть");
//  }

// Задача 3

// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine()); 
// int firstDigit = number / 10; 
// int secondDigit = number % 10;

// if (firstDigit > secondDigit) 
// {
// Console.WriteLine ($"{firstDigit}");    
// }
// else
// {
// Console.WriteLine ($"{secondDigit}");    
// } 

// Задайте массив. Напишите программу, которая определяет,
// присутствует ли заданное число в массиве. Программа
// должна выдать ответ: Да/Нет.
// Примеры
// [1 3 4 19 3], 8 => Нет
// [-4 3 4 1], 3 => Да 

// // тип данных[] имя_массива = new int[размер]
// //int size =10;
// //int[] array = new int [size]; // мы создали массив размером size элементов
// int[] array = { 11, 22, 33, 44, 55, 66, 77};
// Console.Write("Введите число для поиска в массиве: ");
// int numberForSearch = Convert.ToInt32(Console.ReadLine());
// bool isFound = false; // Усли isFound=false, числа в массиве нет
// // точка старта, условие, увеличение переменной-счетчика
// for (int i = 0; i < array.Length; i++)
// {
//     if (numberForSearch == array[i])
//     {
//         isFound = true; // Элемент в массиве найден :)
//         break;
//     }
// }
// if (isFound) // isFound == true
// {
//     Console.WriteLine("Да");
// }
// else // isFound == false
// {
//     Console.WriteLine("Нет");
// }

// Задайте массив из 10 элементов, заполненный числами из
// промежутка [-10, 10]. Замените отрицательные элементы на
// положительные, а положительные на отрицательные.
// Пример
// [1 -5 6]
// => [-1 5 -6]

// int [] array = {1, -2, 3, 4, 5, -1, -7, -8, -9, 10, -5};
// 1 * (-1) = -1
// -5 * (-1) = 5
// for (int i = 0; i < array.Length; i ++)
// {
//     array[i] *= -1; // array[i] = array [i] * -1;
//     Console.Write(array[i] + "\t"); // "\t" = 4 пробела, табуляция
// }
//   2 способ c string.Join

// int [] array = {1, -2, 3, 4, 5, -1, -7, -8, -9, 10, -5};
// Console.WriteLine($"Массив ДО: [ {string.Join("; ", array)} ]");
// for (int i = 0; i < array.Length; i ++)
// {
//     array[i] *= -1; // array[i] = array[i] * -1;
// }
// Console.WriteLine($"Массив ПОСЛЕ: [ {string.Join("; ", array)} ]");

// int [] array = {1, -2, 3, 4, 5, -1, -7, -8, -9, 10, -5};
// int sum = 0; // Найдем сумму элементов между эл. с инд. 1
// // и элементом под индексом 5 (не вкл)

// for (int i =1; i < 5; i++) // i=1,2,3,4
// {
//     sum = sum + array[i]; 
// } 
// Console.WriteLine(sum);

// Задача 3 (3 семинар)
// Найдите произведения пар чисел в одномерном массиве. Парой
// считаем первый и последний элемент, второй и предпоследний и
// т.д. Результат запишите в новый массив.
// Пример
// [1 3 2 4 2 3] => [3 6 8]
// [2 3 1 7 5 6 3] => [6 18 5] (элемент 7 не имеет пары)

// int [] array = {1, -2, 3, 4, 5, -1, -7, -8, -9, 10, -5};
// int [] result = new int[array.Length / 2]; // 7 / 2 = 3
// // индекс первого элемента, j - индекс последнего элемента
// for (int i = 0, j = array.Length - 1 ; i < result.Length; i++, j--)
// {
//    // a = [10,20,30,40], r = [0, 0]
//    // res[0] = a[0] * a[3] = > 400
//    // i++(1), j--(2)
//    // res[1] = a[1] * a[2] = > 600
//    result[i] = array[i] * array[j];
// }
// Console.WriteLine($"Массив: [ {string.Join("; ", array)} ]");
// Console.WriteLine($"Результат: [ {string.Join("; ", result)} ]");

// Семинар 4 Функции или методы

// тип_метода ИмяМетода (пар1, пар2)
// string - массив char-ов
// char ('+', '-')

// int Calculate(int a, int b, char sign)
// {
//     if (sign == '+')
//     {
//         return a + b;
//     }
//     else if (sign == '-')
//     {
//          return a - b;  
//     }
//     else if (sign == '*')
//     {
//          return a * b;
//     }
//     else
//     {
//         Console.WriteLine("Введено неизвестное выражение :(");
//         return 0;
//     }
// }
// // Вызов функции
// int res = Calculate(100, 350, '*');
// Console.WriteLine($"res: {res}");
// Console.WriteLine(Calculate(2, 3, '+'));
// Console.WriteLine(Calculate(20, 30, '*'));
// Console.WriteLine(Calculate(2, 3, '-'));
// Console.WriteLine(Calculate(2, 3, ','));

// Задача 2

// Задайте массив из N случайных целых чисел (N вводится с
// клавиатуры).
// Найдите количество чисел, которые оканчиваются на 1 и
// делятся нацело на 7.
// Пример
// [1 5 11 21 81 4 0 91 2 3]
// => 2

// size = размер, minRange - мин. число в рандомеm,
// maxRange - макс число в рандоме
// using System.ComponentModel.DataAnnotations;

// int[] CreateArray(int size, int minRange, int MaxRange)
// {
//     int [] array = new int[size]; // Массив на size эл
//      for (int i = 0; i < array.Length; i++)
//      {
//           array[i] = new Random().Next(minRange, MaxRange + 1);
//           // Next(0,101) => 0,1,2 ... 100  
//      }
//      return array; 
// }

// int GetCount(int[] arr)
// {
//     int count = 0;
//     foreach (int number in arr) // [1 5 11 21 81 4 0 91 2 3]
//     {
//           if(number % 7 == 0 && number % 10 ==1)
//           {
//              count++;
//           }  
//     }
//     return count;
// }

// Console.Write("Введите размер массива: ");
// int N = Convert.ToInt32(Console.ReadLine());
// int[] array = CreateArray(N, 0, 100);
// // array - массив на N элементов,
// // кажддый элемент - число: [0,100]
// Console.WriteLine($"Массив: [ {string.Join(";", array)} ]");
// Console.WriteLine($"Total: {GetCount(array)}");

// Задание 3

// Заполните массив на N (вводится с консоли, не более 8)
// случайных целых чисел от 0 до 9.
// Сформируйте целое число, которое будет состоять из цифр из
// массива. Старший разряд числа находится на 0-м индексе,
// младший – на последнем.
// Пример
// [1 3 2 4 2 3] => 132423
// [2 3 1] => 231
//
// int[] CreateArray(int size)
// {
//     int [] array = new int[size]; // Массив на size эл
//      for (int i = 0; i < array.Length; i++)
//      {
//           array[i] = new Random().Next(0, 10);
//           // 0, 9
//      }
//      return array; 
// }
// Console.Write("Введите размер массива: ");
// int N = Convert.ToInt32(Console.ReadLine());
// int[] array = CreateArray(N);
// if (array[0] == 0 || N > 8)
// {
//      Console.WriteLine("Размер > 8 эл, или 0 элемент = 0");
//      return;
// }
// Console.WriteLine($"Массив: [ {string.Join("; ", array)} ]");
// int ConvertArrayToInteger(int[] array) 
// {
//      int result = 0;
//      // 294
//      for (int i = 0, j = array.Length - 1; i < array.Length; i++, j--)
//      {
//          result = result + array[i] * (int)Math.Pow(10, j);
//      }
//      return result; 
// }
// Console.WriteLine($"Число: {ConvertArrayToInteger(array)}");

// дз 4 семинар
// задача 1
// Напишите программу, которая бесконечно
// запрашивает целые числа с консоли. Программа
// завершается при вводе символа ‘q’ или при вводе
// числа, сумма цифр которого четная.

// while (true) 
// {
//       Console.Write("Введите текст: ");
//       string text = Console.ReadLine();
//       if (text == "q")
//       {
//           break;
//       }
//       int number; // 0 - если в строчке есть символы
//       if (int.TryParse(text, out number)) // == true
//       {
//           int sum = 0; // 56 => 5 + 6 = 11
//           while(number > 0)
//           {
//                sum += number % 10; // % 10
//                number /= 10;
//           }
//           if (sum % 2 == 0)
//           {
//                break;
//           }
//       }
//       Console.WriteLine(number);
// }

// //  Задача 2
// : Задайте массив заполненный случайными
// трёхзначными числами. Напишите программу,
// которая покажет количество чётных чисел в
// массиве.

// size = размер, minRange - мин. число в рандомеm,
// maxRange - макс число в рандоме
// using System.ComponentModel.DataAnnotations;

// int[] CreateArray(int size)
// {
//     int [] array = new int[size]; // Массив на size эл
//      for (int i = 0; i < array.Length; i++)
//      {
//           array[i] = new Random().Next(100, 1000);
//           // Next(0,101) => 0,1,2 ... 100  
//      }
//      return array; 
// }

// int GetCount(int[] arr)
// {
//     int count = 0;
//     foreach (int number in arr) // [1 5 11 21 81 4 0 91 2 3]
//     {
//           if(number % 2 == 0)
//           {
//              count++;
//           }  
//     }
//     return count;
// }

// Console.Write("Введите размер массива: ");
// int N = Convert.ToInt32(Console.ReadLine());
// int[] array = CreateArray(N);
// // array - массив на N элементов,
// // кажддый элемент - число: [0,100]
// Console.WriteLine($"Массив: [ {string.Join(";", array)} ]");
// Console.WriteLine($"Total: {GetCount(array)}");

// Лекция 4 - 2мерные массивы
// Задача 1
// создать двумерный массив с размерами 3 х 5,
// состоящий из целых чисел. Вывести его элементы на экран.

// int[,] CreateMatrix (int rowcount, int columsCount);
// {
//      int[,] matrix = new int [rowCount, columsCount];

//      Random rnd = new Random();
//      for (int i = 0; i < matrix.GetLength(0); i++)
//      {
//          for (int j = 0; j < matrix.GetLength(1); j++)
//          {
//           matrix[i, j] = rnd.Next(1, 11);
//          } 
//      }
//      return matrix; 
// }  

// void ShowMatrix(int[,] matrix)
// {
//      for (int i = 0; i < matrix.GetLength(0); i++)    
//      {
//           for (int j = 0; j < matrix.GetLength(1); j++)
//           {
//               Console.Write($" {matrix[i, j]} ");
//           }
//           Console.WriteLine();
//      } 
// }
// int [,] CreateMatrix(int rowCount, int columsCount)
// {

//     int[,] matrix =  [rowCount, columsCount];

//     Random rnd = new Random();
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//           matrix[i, j] = rnd.Next(1, 11);
//         }   
//     }
//     return matrix;
// }

// void ShowMatrix(int[,] matrix)
// {
//   for (int i = 0; i < matrix.GetLength(0); i++)
//   {
//       for (int j = 0; j < matrix.GetLength(1); j++)

//      {          
//           Console.Write($" {matrix[i, j]} ");
//      }
//      Console.WriteLine();   
//   }
// }
// int[,] matrix = CreateMatrix(4, 5);
// ShowMatrix(matrix);

//lesson 4 task 2

// int[,] CreateMatrix(int rowcount, int columsCount);
// {
//      int[,] matrix = new int[rowCount, columsCount];

//      Random rnd = new Random();
//      for (int i = 0; i < matrix.GetLength(0); i++)
//      {
//           for (int j = 0; j < matrix.GetLength(1); j++)
//           {
//                matrix[i, j] = rnd.Next(1, 1000);
//           }
//      }
//      return matrix;
// }

// void ShowMatrix(int[,] matrix)
// {
//      for (int i = 0; i < matrix.GetLength(0); i++)    
//      {
//           for (int j = 0; j < matrix.GetLength(1); j++)
//           {
//               Console.Write($" {matrix[i, j]} ");
//           }
//           Console.WriteLine();
//      } 
// }

// int[,] matrix = CreateMatrix(3, 4);
// ShowMatrix(matrix);
// foreach (int e in matrix)
// {
//      if (IsInteresting(e) == true)
//      {
//           Console.WriteLine(e);
//      }
// }
// bool IsInteresting(int value)
// {
//      int sumOfDigits = GetSumOfDigits(value);
//      if (sumOfDigits % 2 == 0)
//      {
//           return true;
//      }  
//           return false;
// }

// int GetSumOfDigits (int value)
// {
//      int sum = 0; 
//      while(value > 0)
//      {
//           sum = sum + value % 10;
//           value = value % 10;
//      }
//      return sum; 
// }

// Lesson4 task3
// Считать с консоли строку, состоящую из цифр 
// латинских букв.
// Сформировать новую строку, состоящую из букв
// исходной строки

// string GetLettrsFromString(string s)
// {
//      string letters = "";
//      foreach(char e in s) 
//      {
//           if( char.IsAsciiLetter(e) == true)
//           {
//            letters = letters + e;
//           }             
//      }
//      return letters;
// }
// string str = Console.ReadLine();
// string result = GetLettrsFromString(str);
// Console.WriteLine(str);

// Leasson4 Task4
// Сообщить о наличии отрицательных элементов 
// в строках 2 мерного массива

// int[,] table = { {1, 1, 1},
//                  {2, -2, 2},             
//                  {3, 3, -3} };
// for (int i = 0; i < table.GetLength(0); i++)
// {
//      for (int j = 0; j < table.GetLength(1); j++)
//      {
//           if (table[i,j] < 0)
//           {
//               Console.WriteLine($" There are negative elements in line{i}");
//               break;
//           }
//      }                  
// }

// Seminar5 Task1
//Задайте двумерный массив. Найдите элементы, у которых оба
//индекса чётные, и замените эти элементы на их квадраты.

// int[,] CreateMatrix (int rows, int cols)
// {
//      int[,] matrix = new int[rows, cols]; // Матрица размером rows стр и calls столбцов
//      Random rnd = new Random();
//      for (int i =0; i < rows; i++)
//      // matrix.GetLength(0) = rows, цикл по строкам 
//      {
//          // j, m, k
//          for (int j = 0; j < cols; j++) // matrix.GetLength(1) = rows, цикл проходит по столбцам
//          {
//            matrix[i, j] = rnd.Next(11); // [0; 10], 11 не входит в диапазон
//          }
//      }
//      return matrix;
// } 

// void PrintMatrix (int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++) // цикл по строчкам    
//      {                  
//          for (int j = 0; j < matr.GetLength(1); j++) // цикл по столбцам
//          {  
//          Console.Write($"{matr[i,j]}\t"); // \t = 4 пробела между элементами 
//          }
//          System.Console.WriteLine();
//      } 
// }

// void SquareElements(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++) // цикл по строчкам    
//      {                  
//          for (int j = 0; j < matr.GetLength(1); j++) // цикл по столбцам
//          {  
//              if (i % 2 == 0 && j % 2 == 0)  
//              {
//                matr[i,j] *= matr[i,j];  // matr[i,j] = matr[i.j] * matr[i,j];
//              }
//          }
//      } 
// }

// Вызов функции
// Console.Write("Введите кол-во строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите кол-во столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// int[,] res = CreateMatrix(rows, columns);
// PrintMatrix(res); // Матрица ДО
// Console.WriteLine("Результат: ");
// // SquareElements(res); // Возведение в квадрат эл.
// PrintMatrix(res); // Матрица ПОСЛЕ
// Console.WriteLine($"Total: {GetMainDiagonalSum(res)}");

// // Задача2 Семинар5
// // Задайте двумерный массив. Найдите сумму элементов,
// // находящихся на главной диагонали (с индексами (0,0); (1;1) итд

// int GetMainDiagonalSum(int[,] matr)
// {
//      int sum = 0;
//          for (int i = 0; i < matr.GetLength(0); i++) // цикл по строчкам    
//      {                  
//          for (int j = 0; j < matr.GetLength(1); j++) // цикл по столбцам
//          {  
//              if (i == j) // Номер стр = номер стлбц  
//              {
//                sum += matr[i, j]; // sum = sum + matr[i, j];
//              }   
//          }
//      } 
//      return sum;
// }

// Task3 Seminar5
// Задайте двумерный массив из целых чисел. Сформируйте новый
// одномерный массив, состоящий из средних арифметических
// значений по строкам двумерного массива. 

// double [] GetArrayWithMeans(int[,] matr)
// {
//      double[] means = new double[matr.GetLength(0)];
//      for (int i = 0; i < matr.GetLength(0); i++) // цикл по строчкам    
//      {                  
//          double currentSum = 0;
//          for (int j = 0; j < matr.GetLength(1); j++) // цикл по столбцам
//          {  
//              currentSum += matr[i,j]; 
//          }
//          means[i] = Math.Round(currentSum / matr.GetLength(1), 2);
//      }
//      return means;
// } 
// Console.Write("Введите кол-во строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите кол-во столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// int[,] res = CreateMatrix(rows, columns);
// PrintMatrix(res); // Матрица ДО
// Console.WriteLine("Результат: ");
// SquareElements(res); // Возведение в квадрат эл.
// PrintMatrix(res); // Матрица после
//Console.WriteLine($"Total: {GetMainDiagonalSum(res)}");
// Console.WriteLine($"Result: [ {string.Join("; ", GetArrayWithMeans(res))} ]");

// Лекция5 Рекурсия

// void OpenMatryoshka(int size)
// {
//     Console.WriteLine($"Opening matryoshka of size {size}...");
//     // Базовый случай: самая маленькая матрешка
//     if ( size ==1)
//     {
//         Console.WriteLine("Reached the smallest matryoshka!");
//         return;
//     }
//     OpenMatryoshka(size - 1);
// }

// OpenMatryoshka(5);

//Task1 Lesson5

// int Fact(int n)
// {
//     if (n == 1 || n == 0)
//     {
//         Console.WriteLine($"Stop requrson:n={n}");
//         return 1;
//     }
//     Console.WriteLine(n);
//     return n * Fact(n - 1);
// }

// Console.Write(Fact(5));

//F11 шаг с заходом
//F10 шаг с обходом
//F5 продолжить (до следующей точки)