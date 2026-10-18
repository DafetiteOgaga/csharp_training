

static void displayDict()
{
	Dictionary<string, int> dictNumbers = new Dictionary<string, int>
	{
		{"david" , 20},
		{"yemi", 34},
		{"sash", 17},
	};
	Console.WriteLine("Looping dict:");
	for (int i = 0; i < dictNumbers.Count; i++)
	{
		Console.WriteLine($"{dictNumbers.ElementAt(i).Key}: {dictNumbers.ElementAt(i).Value}");
	}
	Console.Write("\n");
	if (dictNumbers.TryGetValue("yemi", out int score))
	{
		Console.WriteLine($"Yemi scored: {score}");
	}
}
displayDict();