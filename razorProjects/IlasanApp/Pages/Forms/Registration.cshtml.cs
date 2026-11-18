using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using IlasanApp.Models;
using IlasanApp.Interfaces;
using IlasanApp.Services;
using System.Security.Cryptography;

namespace IlasanApp.Pages.Forms;

public class RegistrationModel : PageModel
{
	private readonly IStudentService _studentService;
	public RegistrationModel(IStudentService studentService)
	{
		_studentService = studentService;
	}

	[BindProperty]
	public Student Student { get; set; } = new();
	public void OnGet()
	{

	}

	public async Task<IActionResult> OnPostAsync()
	{
		if (!ModelState.IsValid)
		{
			return Page();
		}

		await _studentService.AddStudentAsync(new()
		{
			FirstName = Student.FirstName,
			LastName = Student.LastName,
			Email = Student.Email,
			Phone = Student.Phone,
			Age = Student.Age,
			Department = Student.Department,
		});

		// return Page();
		return RedirectToPage("/Index");
	}
}