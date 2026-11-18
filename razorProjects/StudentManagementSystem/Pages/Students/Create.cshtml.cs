using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace StudentManagementSystem.Pages.Students;

public class CreateModel : PageModel
{
	[BindProperty]
	public StudentInput Student { get; set; } = new StudentInput();
	public bool Submitted { get; set; }

	public void OnGet()
	{
		Console.WriteLine("Opening CreateModel using GET method");
	}

	public IActionResult OnPost()
	{
		Console.WriteLine("Attempting to submit in CreateModel using POST method");
		Console.WriteLine("The form was submitted!");
		if (!ModelState.IsValid)
		{
			Console.WriteLine("Validation failed!");
			return Page();
		}

		Console.WriteLine($"Student name: {Student.FullName}");
		Console.WriteLine($"Student email: {Student.Email}");
		Console.WriteLine($"Student age: {Student.Age}");

		Console.WriteLine($"initial count: {StudentStore.Students.Count}");

		StudentStore.Students.Add(new StudentInput
		{
			FullName = Student.FullName,
			Email = Student.Email,
			Age = Student.Age
		});

		Console.WriteLine($"updated count: {StudentStore.Students.Count}");

		Submitted = true;

		Console.WriteLine("Student added successfully!");

		// return Page();
		return RedirectToPage("/Students/Index");
	}
}

public class StudentInput
{
	[Required(ErrorMessage = "Please enter the student's full name.")]
	[StringLength(100)]
	[Display(Name = "Full-name:")]
    public string FullName { get; set; } = string.Empty;

	[Required(ErrorMessage = "Please enter the student's email.")]
	[EmailAddress(ErrorMessage = "Enter a valid email address.")]
	[Display(Name = "Email address:")]
    public string Email { get; set; } = string.Empty;

	[Required(ErrorMessage = "Age is required.")]
	[Range(1, 100, ErrorMessage = "Age must be between 1 and 100.")]
	[Display(Name = "Age:")]
    public int? Age { get; set; }
}