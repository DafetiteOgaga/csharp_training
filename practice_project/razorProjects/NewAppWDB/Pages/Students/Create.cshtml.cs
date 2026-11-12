using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NewAppWDB.Models;
using NewAppWDB.Data;
using NewAppWDB.Interfaces;

namespace NewAppWDB.Pages.Students;

public class CreateModel : PageModel
{
	private readonly IStudentService _studentService;
	public CreateModel(IStudentService studentService)
	{
		_studentService = studentService;
	}

	[BindProperty]
	public Student Student { get; set; } = new();
	public string SubmissionMessage { get; set; } = string.Empty;
	public void OnGet()
	{
		Console.WriteLine("Get request invoked");
	}

	public async Task<IActionResult> OnPostAsync()
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
		// Console.WriteLine($"Mem before: {_studentService.Students.Count()}");
		await _studentService.AddStudentAsync(new() {
				FirstName = Student.FirstName,
				LastName = Student.LastName,
				Age = Student.Age
			}
		);
		// Console.WriteLine($"Mem after: {_studentService.Students.Count()}");
		Console.WriteLine("Redirecting home");
		return RedirectToPage("/Index");
	}
}
