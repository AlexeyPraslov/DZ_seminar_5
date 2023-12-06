// Задача 2: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

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

        for (int i = 0; i < cols; i++) // Меняем местами первую и последнюю строки
        {
            int temp = array[0, i];
            array[0, i] = array[rows - 1, i];
            array[rows - 1, i] = temp;
        }

        for (int i = 0; i < rows; i++) // Выводим измененный массив
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
