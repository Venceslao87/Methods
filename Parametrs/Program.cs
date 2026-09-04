Console.Title = "Working with parameters";
// Input quantity
Console.Write("Input the quantity of numbers: ");
int input = int.Parse(Console.ReadLine());
//Call the method
Count(input);

// Description method
void Count(int current)
{
    for (int index = 0; index <= current; index++)
        Console.WriteLine(index);
}