
// sum method
static double add(double a, double b)
{
	return a + b;
}

// difference method
static double subtract(double a, double b)
{
	return a - b;
}

// product method
static double multiply(double a, double b)
{
	return a * b;
}

// division method
static double divide(double a, double b)
{
	return a / b;
}

static string invalid()
{
	return "You entered an invalid entry";
}

static void nl() {
	Console.Write("\n");
}

// calculator
static void calculator()
{
	Console.Write("Enter first number: ");
	string? num1 = Console.ReadLine();
	if (int.TryParse(num1, out int a))
	{
		Console.Write("Enter second number: ");
		string? num2 = Console.ReadLine();
		nl();
		if (int.TryParse(num2, out int b))
		{
			string[] operators = { "+", "-", "x", "/" };
			int i = 0;
			while (i <= 3)
			{
				Console.WriteLine($"Press {i} for {operators[i]}");
				// if (i == 4)
				// {
				// 	break;
				// }
				i++;
			}
			Console.Write("Select operator: ");
			string? rawSelection = Console.ReadLine();
			nl();
			if (int.TryParse(rawSelection, out int selectedIndex))
			{
				string selectedOperator = operators[selectedIndex];
				// string operatorVerb = "";
				double answer = 0;
				if (selectedOperator == "+")
				{
					// operatorVerb = "adding";
					answer = add(a, b);
				} else if (selectedOperator == "-")
				{
					// operatorVerb = "subtracting";
					answer = subtract(a, b);
				} else if (selectedOperator == "x")
				{
					// operatorVerb = "multiplying";
					answer = multiply(a, b);
				} else if (selectedOperator == "/")
				{
					// operatorVerb = "dividing";
					answer = divide(a, b);
				}
				Console.WriteLine($"The result of {a}{selectedOperator}{b} is {answer}");
			}
			else
			{
				Console.WriteLine(invalid());
			}
		}
		else
		{
			Console.WriteLine(invalid());
		}
	}
	else
	{
		Console.WriteLine(invalid());
	}
}

calculator();
