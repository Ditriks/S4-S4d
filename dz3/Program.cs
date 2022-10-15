// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] array = new int[8];
Random myRandom = new Random();
 
Console.WriteLine("Массив из восьми случайных чисел");
for (int i = 0; i < array.Length; i++)
    {
        array[i] = myRandom.Next(0, 99);
        Console.Write("{0} ", array[i]);
    }
 
            