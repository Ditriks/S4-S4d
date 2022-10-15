// напишите программу, которая принимает число N и выдает сумму чисел от 1 до N

Console.Write("Введите любое число: ");
int x = Convert.ToInt32(Console.ReadLine());
int i = 0;
int res = 0;

while (i <= x)
{
    res = res + i;
    i++;
}

Console.WriteLine(res);