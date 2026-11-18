
// string ln = "\n";
// a top level method that prints an empty newline
static void ln()
{
	Console.WriteLine("\n");
}
// Console.WriteLine(ln);
ln(); // new line

Console.Write("Enter your name: ");

string? inName = Console.ReadLine();

ln(); // new line
Console.WriteLine($"Hello, {inName}!\nYou are writing in C#");

// ln(); // new line
// Console.WriteLine("hello from c# here");
// Console.WriteLine(ln);

// arrays
string[] colors = { "blue", "red", "green", "white" };

ln(); // new line
string name = "Ogaga";
int age = 25;

// conditional
if (age >= 18)
{
	Console.WriteLine($"Hey {name}, You are an adult");
}
else
{
	Console.WriteLine($"Hey {name}, You are not yet an adult");
}
// Console.WriteLine(ln);
ln(); // new line
Console.WriteLine("loop in c#:");
// for loop
for (int num = 1; num <= 10; num++)
{
	int mult = 2 * num;
	Console.WriteLine($"{num} x 2 = {mult}");
}

ln(); // new line
// for loop (array)
foreach (string str in colors)
{
	string res = $"color: {str}";
	Console.WriteLine(res);
}

ln(); // new line
	  // instance
ShoeSize shoesize1 = new ShoeSize(23, 4);
shoesize1.Display();

// class
public class ShoeSize
{
	// the properties
	public int Length { get; set; }
	public int Breadth { get; set; }

	// constructor
	public ShoeSize(int length, int breadth)
	{
		Length = length;
		Breadth = breadth;
	}

	// method
	public void Display()
	{
		int mult = Length * Breadth;
		string res = $"Your shoe size is {Length} x {Breadth} and the result is: {mult}";
		Console.WriteLine(res);
	}
}
