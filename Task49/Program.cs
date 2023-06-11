// **Задача 49:** Задайте двумерный массив. // Найдите элементы, у которых оба индекса чётные,
// и замените эти элементы на их квадраты. // Например, изначально массив выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 2 3 4
// Новый массив будет выглядеть вот так:
// 1 4 7 2
// 5 **81** 2 **9**
// 8 4 2 4
// 1 **4** 3 **16**
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
void ArraySqr(int[,] array)
{
    for (int i = 0; i<array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) array[i,j]*= j%2==0&&i%2==0 ? array[i,j]:1;  
    }
}
Clear();
int m = Enter("Введите m");
int n = Enter("Введите n");
int [,] array = GetArray(m,n);
PrintArray(array);
WriteLine();
ArraySqr(array);
PrintArray(array);
