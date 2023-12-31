﻿//Задача 3: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

using System;

class Program
{
    static void Main()
    {        
        int[,] array = new int[,] { { 1, 2, 3 }, // Создаем двумерный массив
                                    { 4, 5, 6 }, 
                                    { 7, 8, 9 } };
        
        int rows = array.GetLength(0); // Получаем количество строк и столбцов
        int cols = array.GetLength(1);
        
        int minSum = int.MaxValue;// Инициализируем переменные для хранения минимальной суммы и номера строки
        int minRow = -1;
        
        for (int i = 0; i < rows; i++) // Проходим по всем строкам
        {           
            int sum = 0; // Вычисляем сумму элементов в текущей строке
            for (int j = 0; j < cols; j++)
            {
                sum += array[i, j];
            }
            
            if (sum < minSum) // Если сумма меньше минимальной, то обновляем минимальную сумму и номер строки
            {
                minSum = sum;
                minRow = i;
            }
        }
      
        Console.WriteLine("Номер строки с наименьшей суммой элементов: " + minRow); // Выводим номер строки с наименьшей суммой элементов
    }
}