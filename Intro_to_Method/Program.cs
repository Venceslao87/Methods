Console.Title = "Introduce the Method";
Console.WriteLine("Hello, World!");
CountToTen();
void CountToTen()
{
    int sum = 0;
    for (int index = 1; index <= 10; index++)
    {
        sum += index;
        Console.WriteLine(index);
    }
    Console.WriteLine($"The sum of numbers is {sum}");
}
