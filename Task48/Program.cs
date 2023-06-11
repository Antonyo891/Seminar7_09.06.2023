// **Задача 48:** Задайте
// двумерный массив размера m на n, каждый элемент
// в массиве находится по формуле: A[i, j] = i + j.
//Выведите полученный массив на экран.

// m = 3, n = 4.

// 0 1 2 3

// 1 2 3 4

// 2 3 4 5
using System;
using static System.Console;
int [,] GetArray (int line, int column) // создает двумерный массив с элементами [i,j]= i+j
{
    int[,] result = new int [line,column];
    for (int i=0;i<line;i++)
    {
        for (int j=0; j<column; j++) result[i,j] = i+j;
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
Clear();
int m = Enter("Введите m");
int n = Enter("Введите n");
PrintArray(GetArray(m,n)); 


