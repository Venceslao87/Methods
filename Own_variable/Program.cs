//Understanding of the own variable in Methods in C#
Console.Title = "Own Variable in Methods";
//Intro general variable
Console.WriteLine("Input the general variable");
int current = int.Parse(Console.ReadLine());
// Call the methods
CountToTen();
CountToTwenty();

// The space of description of the methods
void CountToTen()
{
    for (int current = 1 /* the own variables of method */; current <= 10; current++)
        Console.WriteLine(current);
}
void CountToTwenty()
{
    for (int current = 1 /* the own variables of method */; current <= 20; current++)
        Console.WriteLine(current);
}