void NewLine<T>(T data = default)
	=> Console.WriteLine(
		data is null ? "" : $"data provided: {data}"
	);

void PrintList<T>(IEnumerable<T> ListItem)
{
	foreach (var item in ListItem)
	{
		Console.Write($"{item}, ");
	};
}

List<string> students = new()
{
	"John",
	"Mary",
	"Peter",
	"James",
	"Grace"
};

var result = students
    .Where(student => student.StartsWith("J"))
    .ToList();

foreach (var student in result)
{
	NewLine(student);
}

NewLine<string>();

List<string> res = new();
foreach (string student in students)
{
	if (student.StartsWith("G")){
		NewLine($"adding: {student} to res");
		res.Add(student);
	}
}

List<int> numbers = new() { 2, 5, 8, 10, 13, 16 };
var EvenNums = numbers.Where(i => i % 2 == 0);
NewLine<string>();
PrintList(EvenNums);

var Selecting = numbers.Select(i => i > 5);
NewLine<string>();
PrintList(Selecting);

var Ordered = numbers.OrderByDescending(number=>number);
NewLine<string>();
PrintList(Ordered);

var firstDefault = numbers.FirstOrDefault(number => number == 16);
NewLine<string>();
NewLine(firstDefault);

var counting = numbers.Count();
NewLine<string>();
NewLine(counting);

var studExists = students.Any(student => student == "John");
NewLine<string>();
NewLine(studExists);
