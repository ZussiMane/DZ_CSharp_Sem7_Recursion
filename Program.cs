﻿// Задача 1: Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.

// Console.Write("Введите число M: "); // Запрос ввода числа M у пользователя
// int m = int.Parse(Console.ReadLine()); // Считывание строки, введенной пользователем, и преобразование ее в целое число

// Console.Write("Введите число N: "); // Запрос ввода числа N у пользователя
// int n = int.Parse(Console.ReadLine()); // Считывание строки, введенной пользователем, и преобразование ее в целое число

// void PrintNumbers(int m, int n) // Объявление функции, которая принимает два целых числа в качестве аргументов
// {
//     if (m <= n) // Проверка: не превышает ли текущее число верхнюю границу
//     {
//         Console.WriteLine(m); // Вывод текущего числа

//         PrintNumbers(m + 1, n); // Рекурсивный вызывов функции с увеличенным значением на 1
//     }
// }

// PrintNumbers(m, n); // Вызов функции с заданными значениями
//--------------------------------------------------------------//
// Задача 2: Напишите программу вычисления функции Аккермана 
// с помощью рекурсии. Даны два неотрицательных числа m и n.

// Console.Write("Введите число m: "); // Запрос ввода числа m у пользователя
// int m = int.Parse(Console.ReadLine()); // Считывание строки, введенной пользователем, и преобразование ее в целое число

// Console.Write("Введите число n: "); // Запрос ввода числа n у пользователя
// int n = int.Parse(Console.ReadLine()); // Считывание строки, введенной пользователем, и преобразование ее в целое число

// int Ackermann(int m, int n) // Объявление функции Аккермана, которая принимает два целых числа в качестве аргументов
// {
//     if (m == 0) // Проверка значение m: если m равно 0, то
//     {
//         return n + 1; // возвращается n+1
//     }
//     else if (m > 0 && n == 0) // Если m больше 0 и n равно 0, то
//     {
//         return Ackermann(m - 1, 1); // рекурсивно вызывается функция Аккермана с m-1 и 1
//     }
//     else
//     {
//         return Ackermann(m - 1, Ackermann(m, n - 1)); // Иначе рекурсивно вызывается функция Аккермана с m-1 и Ackermann(m, n-1)
//     }
// }

// Console.WriteLine("Результат функции Аккермана: " + Ackermann(m, n)); // Вызов функции Аккермана с заданными значениями и вывод результата
//--------------------------------------------------------------//
// Задача 3: Задайте произвольный массив. Выведете его элементы, 
// начиная с конца. Использовать рекурсию, не использовать циклы.

int[] array = new int[] { 1, 2, 3, 4, 5 }; // Объявление и инициализация произвольного массива

void PrintReverse(int[] arr, int index) // Объявление рекурсивной функции для вывода элементов массива в обратном порядке
{
    if (index >= 0) // Проверка: не вышли ли мы за границы массива
    {
        Console.WriteLine(arr[index]); // Вывод текущего элемента

        PrintReverse(arr, index - 1); // Рекурсивный вызов функции для следующего элемента
    }
}

PrintReverse(array, array.Length - 1); // Вызывов функции, передавая ей массив и индекс последнего элемента