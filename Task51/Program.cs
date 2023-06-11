// Задача 51: Задайте двумерный массив.
// Найдите сумму элементов, находящихся
// на главной диагонали (с индексами (0,0); (1; 1) и т.д. Используя 1 цикл.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12
using System;
using static System.Console;
int [,] GetArray (int line, int column) // создает двумерный массив с рандомными элементами
{
    int[,] result = new int [line,column];
    for (int i=0;i<line;i++)
    {
        for (int j=0; j<column; j++) result[i,j] = new Random().Next(0,10);
    }
    return result;
}
int Enter(string text) // запрос на ввод целого числа
{
    WriteLine(text);
    int result = int.Parse(ReadLine());
    return result;
}
void PrintArray (int [,] array)
{ for (int i = 0; i< array.GetLength(0); i++)
{
    for (int j =0; j<array.GetLength(1);j++) Write($" {array[i,j]}");
    WriteLine();
}
}
int SumDiagonal(int[,] array)
{
    int result = 0;
    int length = array.GetLength(0)<array.GetLength(1) ? array.GetLength(0):array.GetLength(1);
    for (int i = 0; i<length; i++) result = result + array[i,i];
    return result;
}
Clear();
int m = Enter("Введите число строк");
int n = Enter("Введите число столбцов");
int [,] array = GetArray(m,n);
PrintArray(array);
WriteLine($"Сумма элементов главной диагонали = {SumDiagonal(array)}");


