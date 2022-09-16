// Задача 1: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
/*
int x = Convert.ToInt32(Console.ReadLine());
int y = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[x, y];

Random random = new Random();
for (int i = 0; i < x; i++)
    {
    for (int j = 0; j < y; j++)
        {
            array[i, j] = random.Next(-100, 100);
            Console.Write("{0,4}", array[i, j]);
        }
        Console.WriteLine();
    }

*/

// Задача 2: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
/*
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[x, y];

            Random random = new Random();
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    array[i, j] = random.Next(-100, 100);
                    Console.Write("{0,4}", array[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Введите номер столбца");
            int w = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите номер строки");
            int c = Convert.ToInt32(Console.ReadLine());

            if (c < 0 | c > array.GetLength(0) | w < 0 | w > array.GetLength(1))
            {
                Console.WriteLine("Элемент не существует");
            }
            else
            {
                Console.WriteLine("Значение элемента массива = {0}", array[c-1, w-1]);
            }
            Console.ReadLine();
*/

//Задача 3: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
/*
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[x, y];

            Random random = new Random();
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    array[i, j] = random.Next(-100, 100);
                    Console.Write("{0,4}", array[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();

            for (int i = 0; i < array.GetLength(1); i++)
            {
                double sum = 0;
                for (int j  = 0; j < array.GetLength(0); j++)
                {
                    sum += array[j, i];
                }
                Console.Write($"{ sum / array.GetLength(0)} ");
            }
*/
