using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NewAppWDB.Models;
using NewAppWDB.Data;

namespace NewAppWDB.Pages.Students;

public class CreateModel : PageModel
{
	[BindProperty]
	public Student Student { get; set; } = new();
	public string SubmissionMessage { get; set; } = string.Empty;
	public void OnGet()
	{
		Console.WriteLine("Get request invoked");
	}

	public IActionResult OnPost()
	{
		Console.WriteLine("Post request invoked");
		Console.WriteLine(
			$"First name: {Student.FirstName}\n" +
			$"Last name: {Student.LastName}\n" +
			$"Age: {Student.Age}"
		);

		if (!ModelState.IsValid)
		{
			return Page();
		}

		SubmissionMessage = $"Student Registered: {Student.FirstName} {Student.LastName}, Age: {Student.Age}";
		Console.WriteLine($"SubmissionMessage: {SubmissionMessage}");
		Console.WriteLine($"Mem before: {StudentStore.Students.Count()}");
		StudentStore.AddStudent(new() {
				FirstName = Student.FirstName,
				LastName = Student.LastName,
				Age = Student.Age
			}
		);
		Console.WriteLine($"Mem after: {StudentStore.Students.Count()}");
		Console.WriteLine("Redirecting home");
		return RedirectToPage("/Index");
	}
}
