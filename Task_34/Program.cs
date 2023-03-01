﻿// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// создаем массив  из 10 случайных трехзначных чисел 

int[] array = new int[10];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(100, 1000);
    Console.Write($" {array[i]} "); //выводим массив на экран
}
// вводим переменную куда мы будем складывать количество четных чисел в массиве

int count = 0; //счетчик

// делаем цикл, который будет делать проверку на четность и, в случае если число четное, увеличивать значение переменной на 1
for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0) count++;
}
// выводим резуьтат на консоль
Console.WriteLine($"-> {count}");
