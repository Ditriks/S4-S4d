// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

int Sum(int N){
    
    int counter = Convert.ToString(N).Length;
    int advance = 0;
    int result = 0;

    for (int i = 0; i < counter; i++){
      advance = N - N % 10;
      result = result + (N - advance);
      N = N / 10;
    }
   return result;
}

int sum = Sum(N);

Console.WriteLine("Сумма всех цифр: " + sum);
