//Создать двумерный массив и вывести его на экран
using System;
using static System.Console;
int[,] RandomArray(int line, int column, int min, int max) // создает рандомный двумерный массив из целых чисел
{
    int[,] result = new int[line, column];
    for (int i = 0; i < line; i++)
    {
        for (int j = 0; j < column; j++) result[i, j] = new Random().Next(min, max + 1);
    }
    return result;
}
void PromtArray(int[,] array) //выводит двумерный массив
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) Write($" {array[i, j]}");
        WriteLine();
    }
}
int Enter(string text) // запрос на ввод целого числа
{
    WriteLine(text);
    int result = int.Parse(ReadLine());
    return result;
}
Clear();
int line = Enter("Число строк - ");
int column = Enter("Число столбцов -");
int min = Enter("Минимум");
int max = Enter("Максимум");
PromtArray(RandomArray(line, column, min, max));