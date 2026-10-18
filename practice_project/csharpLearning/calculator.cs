

Calculator instance1 = new Calculator();
instance1.calculate();

public class Calculator {
	public double ans = 0;
	public int num1;
	public int num2;
	string ln = "\n";

	public void calculate() {
		string invalidEntry = "You entered an invalid entry";
		Console.Write("Enter first number: ");
		string? a1 = Console.ReadLine();
		if (int.TryParse(a1, out int num1)) {
			Console.Write("Enter second number: ");
			string? a2 = Console.ReadLine();
			Console.Write(ln);
			if (int.TryParse(a2, out int num2)) {
				
				string[] operators = { "+", "-", "x", "/" };
				int i = 0;
				while (i < 4) {
					Console.WriteLine($"Press {i} for: {operators[i]}");
					if (i == 4) {
						break;
					}
					i += 1;
				}
				Console.Write("Select operation: ");
				string? opert = Console.ReadLine();
				Console.Write(ln);
				if (int.TryParse(opert, out int intOpert) && intOpert >= 0 && intOpert < 4) {
					double answer = 0;
					string val = operators[intOpert];
					string operation = "";
					if (val == "+") {
						operation = "adding";
						answer = Add(num1, num2);
					} else if (val == "-") {
						operation = "subtracting";
						answer = Subtract(num1, num2);
					} else if (val == "x") {
						operation = "multiplying";
						answer = Multiply(num1, num2);
					} else {
						operation = "dividing";
						answer = Divide(num1,num2);
					}
					string res = $"The result of {operation} {num1} and {num2} is {answer}";
					Console.WriteLine(res);
				} else {
					Console.WriteLine(invalidEntry);
				}
			} else {
				Console.WriteLine(invalidEntry);
			}
		} else {
			Console.WriteLine(invalidEntry);
		}
	}
	public double Add(double a, double b) {
		ans = a + b;
		return ans;
	}
	public double Subtract(double a, double b) {
		ans = a - b;
		return ans;
	}
	public double Multiply(double a, double b) {
		ans = a * b;
		return ans;
	}
	public double Divide(double a, double b) {
		ans = a / b;
		return ans;
	}
}
