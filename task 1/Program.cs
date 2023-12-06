// Задача 1: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

using System;

class Program
{
    static void Main()
    {
        int[,] matrix = { // Создаем двумерный массив (матрицу)
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        Console.Write("Введите номер строки: ");// Запрашиваем у пользователя позиции элемента
        int row = int.Parse(Console.ReadLine());

        Console.Write("Введите номер столбца: ");
        int column = int.Parse(Console.ReadLine());

        int result = GetMatrixElement(matrix, row, column);// Получаем и выводим значение элемента или сообщение об отсутствии элемента
        if (result != int.MinValue)
        {
            Console.WriteLine($"Значение элемента на позиции ({row}, {column}): {result}");
        }
        else
        {
            Console.WriteLine($"Элемента на позиции ({row}, {column}) не существует.");
        }
    }
    static int GetMatrixElement(int[,] matrix, int row, int column) // Функция для получения значения элемента в двумерном массиве
    {
        int rowCount = matrix.GetLength(0);
        int columnCount = matrix.GetLength(1);

        if (row >= 0 && row < rowCount && column >= 0 && column < columnCount) // Проверяем, существуют ли указанные позиции в массиве
        {
            return matrix[row, column];// Возвращаем значение элемента
        }
        else
        {
            return int.MinValue; // Возвращаем специальное значение, указывающее, что элемента нет
        }
    }
}