﻿// Задайте массив из 10 целых чисел. Найдите среднее значение элементов
// массива

using System;
using System.Linq;
class Program
{
static double CalculateAverage(int[] numbers)
{
double sum = numbers.Sum();
return sum / numbers.Length;
}
static void Main(string[] args)
{
int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }; 
double average = CalculateAverage(numbers);
Console.WriteLine(average);
}
}

