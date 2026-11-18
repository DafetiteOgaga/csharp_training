using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NewAppWDB.Data;
using NewAppWDB.Models;
using NewAppWDB.Interfaces;

namespace NewAppWDB.Pages.Students;

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
			Console.WriteLine($"Student: {Student}");
			Console.WriteLine("Student not found (used Get request in Delete Model)");
			return NotFound();
		}
		Console.WriteLine(
			$"Get Id: {id}\n" +
			$"First name: {Student.FirstName}\n" +
			$"Student age: {Student.Age}"
		);
		return Page();
	}

	public async Task<IActionResult> OnPostAsync(int id)
	{
		Console.WriteLine($"form ID: {id}");
		var student = await _studentService.GetStudentByIdAsync(id);

		if (student == null)
		{
			Console.WriteLine($"Student: {Student}");
			Console.WriteLine("Student not found (used Post request in Delete Model)");
			return NotFound();
		}
		Console.WriteLine("Removing student record");
		await _studentService.DeleteStudentAsync(id);

		return RedirectToPage("/Index");
	}
}
