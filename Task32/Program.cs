// Задача 31: Задайте массив из 12 элементов. Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

Console.Clear();
Console.WriteLine("Введите массив, состоящий из 12 элементов\t");
int[] array = new int[12]; 
int sum = 0;
int sum2 = 0;
 
    for (int i = 0; i < array.Length; i++)
        {   
            Console.WriteLine($"Введите элемент массива под индексом {i}");
            array[i] = Convert.ToInt32(Console.ReadLine());
        }
        
    for (int i = 0; i < array.Length; i++) 
        {
        if (array[i] > 0)
            sum = sum + array[i];
    
        else 
            sum2 = sum2 + array[i];
        }
                Console.WriteLine($"Сумма положительных чисел в массиве {sum}");
                Console.WriteLine($"Сумма отрицательных чисел в массиве {sum2}");    
           
          
           
//         for (int i = 0; i < array.Length; i++)
//         array[i] = new Random().Next(-9, 10);


//             Console.WriteLine($"Введите элемент массива под индексом {i}");
//             array[i] = Convert.ToInt32(Console.ReadLine());

//             Console.Clear();
// Console.Write("Введите кол-во элементов массива: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[n];

        
                

       
        