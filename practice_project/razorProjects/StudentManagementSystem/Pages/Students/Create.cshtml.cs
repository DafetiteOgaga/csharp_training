using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace StudentManagementSystem.Pages.Students;

public class CreateModel : PageModel
{
	[BindProperty]
	public StudentInput Student { get; set; } = new();
	public bool Submitted { get; set; }

	public void OnGet()
	{

	}

	public IActionResult OnPost()
	{
		if (!ModelState.IsValid)
		{
			return Page();
		}

		StudentStore.Students.Add(new StudentInput
		{
			FullName = Student.FullName,
			Email = Student.Email,
			Age = Student.Age
		});

		Submitted = true;

		return Page();
	}
}

public class StudentInput
{
    [Required(ErrorMessage = "Please enter the student's full name.")]
    [StringLength(100)]
    public string FullName { get; set; } = string.Empty;

    [Required(ErrorMessage = "Please enter the student's email.")]
    [EmailAddress(ErrorMessage = "Enter a valid email address.")]
    public string Email { get; set; } = string.Empty;

    [Range(1, 100, ErrorMessage = "Age must be between 1 and 100.")]
    public int Age { get; set; }
}