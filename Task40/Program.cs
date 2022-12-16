// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.


void InputArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)                                                                            //(end - begin) + begin
        array[i] = Convert.ToDouble(new Random().Next(-100, 1000)) / 100; // double val = new Random().NextDouble() * (10 - 1) + 1 // [0, 1]
}                                                                         // Console.WriteLine(Math.Round(val, 2));

void ReleaseArray(double[] array)
{
    double max = 0;
    double min = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
            max = array[i];

        else
            min = array[i];
    }
    Console.WriteLine($"Максимальное значение = {max}, минимальное значение = {min}");
    Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");

}

Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
double[] array = new double[n];
InputArray(array);
Console.WriteLine($"[{string.Join("   ", array)}]");
ReleaseArray(array);


// void InputArray(double[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//         array[i] = Math.Round(new Random().NextDouble() * (20 - 10) + 10, 2);
// }


// double MaxArray(double[] array)
// {
//     double maxArray = array[0];
//     for (int i = 1; i < array.Length; i++)
//     {
//         if (maxArray < array[i])
//             maxArray = array[i];
//     }
//     return maxArray;
// }

// double MinArray(double[] array)
// {
//     double minArray = array[0];
//     for (int i = 1; i < array.Length; i++)
//     {
//         if (minArray > array[i])
//             minArray = array[i];
//     }
//     return minArray;
// }

// Console.Clear();
// Console.Write("Введите кол-во элементов массива: ");
// int n = Convert.ToInt32(Console.ReadLine());
// double[] array = new double[n];
// InputArray(array);
// Console.WriteLine($"Наальный массив: [{string.Join(", ", array)}]");
// Console.WriteLine($"Результат: {MaxArray(array) - MinArray(array)}");

