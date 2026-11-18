

static void displayList()
{
	List<int> numbers = new List<int>
	{
		0, 1, 2, 3, 4, 5, 6, 7, 8, 9
	};
	foreach (int num in numbers)
	{
		Console.WriteLine($"{num} x 2 = {num * 2}");
	}
}
displayList();