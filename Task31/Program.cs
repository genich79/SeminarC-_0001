// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

Console.Clear();
Console.WriteLine("Введите массив, состоящий из 8 элементов\t");
int[] array = new int[8];
    for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine($"Введите элемент массива под индексом {i}");
            array[i] = Convert.ToInt32(Console.ReadLine());
        }

            Console.Write("Вывод массива: ");
            Console.Write($"[{string.Join(", ", array)}]");
            
           


         
            



