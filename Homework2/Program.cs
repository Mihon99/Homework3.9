int M = InputValue("Введите первое число");
int N = InputValue("Введите второе число");
Console.WriteLine($"Сумма чисел = {SumNumbers(M,N)} ");

int InputValue(string message)
{
    Console.WriteLine(message);
    string value = Console.ReadLine();
    int a = int.Parse(value);
    return a;
}

int SumNumbers (int a, int b)
{
    if(a > b) return 0;    
    return a + SumNumbers(a + 1, b);
}

