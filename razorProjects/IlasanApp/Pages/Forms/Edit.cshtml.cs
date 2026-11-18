using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using IlasanApp.Interfaces;
using IlasanApp.Models;
using IlasanApp.Services;

namespace IlasanApp.Pages.Forms;

public class EditModel : PageModel
{
	private readonly IStudentService _studentService;
	public EditModel(IStudentService studentServies)
	{
		_studentService = studentServies;
	}

	[BindProperty]
	public Student? Student { get; set; }
	public async Task<IActionResult> OnGetAsync(int id)
	{
		Student = await _studentService.GetStudentByIdAsync(id);
		if (Student == null)
		{
			Console.WriteLine("Page not found");
			return NotFound();
		}
		return Page();
	}

	public async Task<IActionResult> OnPostAsync()
	{
		if (Student == null)
		{
			Console.WriteLine("Student not found");
			return NotFound();
		}
		if (!ModelState.IsValid)
		{
			return Page();
		}

		await _studentService.UpdateStudentAsync(Student);

		Console.WriteLine("Update success");
		return RedirectToPage("/Index");
	}
}