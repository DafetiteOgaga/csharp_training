using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NewAppWDB.Data;
using NewAppWDB.Models;
using NewAppWDB.Interfaces;

namespace NewAppWDB.Pages.Students;

public class EditModel : PageModel
{
	private readonly IStudentService _studentService;
	public EditModel(IStudentService studentService)
	{
		_studentService = studentService;
	}
	[BindProperty]
	public Student? Student { get; set; }
	public async Task<IActionResult> OnGetAsync(int id)
	{
		Student = await _studentService.GetStudentByIdAsync(id);

		if (Student == null)
		{
			Console.WriteLine("Student not found (used Get request in Edit Model)");
			return NotFound();
		}
		return Page();
	}

	public async Task<IActionResult> OnPostAsync()
	{
		if (Student == null)
		{
			Console.WriteLine("Student not found (used Post request in Edit Model)");
			return NotFound();
		}

		if (!ModelState.IsValid)
		{
			return Page();
		}

		await _studentService.UpdateStudentAsync(Student);

		Console.WriteLine("Update successful");

		return RedirectToPage("/Index");
	}
}