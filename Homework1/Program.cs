string Reqursia(int a)
{
    if(a == 1) return "1";
    else return  $"{a}, {Reqursia(a - 1)}";       
}

int r = PrintAndGetValue("Максимум");

Console.WriteLine($"{Reqursia(r)} ");

int PrintAndGetValue(string message)
{
    Console.WriteLine(message);
    int input = int.Parse(Console.ReadLine());
    return input;
}