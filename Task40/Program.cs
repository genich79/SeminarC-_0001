// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.


void InputArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = Convert.ToDouble(new Random().Next(-100, 1000)) / 100;
}

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