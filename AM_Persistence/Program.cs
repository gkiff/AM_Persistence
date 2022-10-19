Console.Write("Enter integer (0-99): ");
int Value = Convert.ToInt16(Console.ReadLine());
Console.Write("Calculate additive or multiplicative persistence (a or m)? ");
string Operation = Console.ReadLine();
int Count = 0;

while(Value > 9)
{
    if(Operation == "a")
    {
        Value = (Value / 10) + (Value % 10);
    }
    else
    {
        Value = (Value / 10) * (Value % 10);
    }
    Count ++;
}

Console.Write("The persistence is: ");
Console.WriteLine(Count);
