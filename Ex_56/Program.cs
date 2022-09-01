/* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка */

class Program
{
    static void Main()
    {
        Console.Clear();
        Console.WriteLine("Введите количество строк m: ");
        int m = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите количество элементов массива в строке n: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int[,] array = new int[m, n];
        Random myRandom = new Random();
        Console.WriteLine(" ");
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                array[i, j] = myRandom.Next(0, 10 + n);
                Console.Write("{0}\t", array[i, j]);
            }
            Console.WriteLine(" ");
        }
        int result = 1;
        int temp1 = 0, temp2 = 0;
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (i == 0)
                {
                    temp2 += array[i, j];
                    temp1 = temp2;
                }
                else { temp2 += array[i, j]; }
            }
            if (temp1 > temp2)
            {
                result = i + 1;
                temp1 = temp2;
                temp2 = 0;
            }
            temp2 = 0;
        }
        Console.WriteLine(" ");
        Console.Write("строка с наименьшей суммой элементов: {0}", result);
        Console.WriteLine(" ");
        Console.WriteLine(" ");
    }
}