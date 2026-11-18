using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using IlasanApp.Interfaces;
using IlasanApp.Services;
using IlasanApp.Models;

namespace IlasanApp.Pages.Forms;

public class DeleteModel : PageModel
{
	private readonly IStudentService _studentService;
	public DeleteModel(IStudentService studentService)
	{
		_studentService = studentService;
	}

	public Student? Student { get; set; }

	public async Task<IActionResult> OnGetAsync(int id)
	{
		Student = await _studentService.GetStudentByIdAsync(id);
		if (Student == null)
		{
			Console.WriteLine("student not found");
			return NotFound();
		}
		return Page();
	}

	public async Task<IActionResult> OnPost(int id)
	{
		var student = await _studentService.GetStudentByIdAsync(id);
		if (student == null)
		{
			Console.WriteLine("page not found");
			return NotFound();
		}
		await _studentService.DeleteStudentAsync(id);

		return RedirectToPage("/Index");
	}
}