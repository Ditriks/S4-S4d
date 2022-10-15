// Напишите программу, которая принимает на вход число
// и выдает количество цифр в числе

Console.Write("Введите число: ");
int x = Convert.ToInt32(Console.ReadLine());
int Dl = 0;

while (x >= 1)
{
    x = x/10;
    Dl++;
}

Console.WriteLine(Dl);