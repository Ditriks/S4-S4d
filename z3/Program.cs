// напишите программу, которая принимает число N и выдает 
// произведение чисел от 1 до N

Console.Write("Введите любое число: ");
int x = Convert.ToInt32(Console.ReadLine());
int i = 1;
int res = 1;

while (i <= x)
{
    res = res * i;
    i++;
}

Console.WriteLine(res);
