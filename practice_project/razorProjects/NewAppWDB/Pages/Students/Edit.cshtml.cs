using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NewAppWDB.Data;
using NewAppWDB.Models;

namespace NewAppWDB.Pages.Students;

public class EditModel : PageModel
{
	[BindProperty]
	public Student? Student { get; set; }
	public IActionResult OnGet(int id)
	{
		Student = StudentStore.Students.FirstOrDefault(student => student.Id == id);

		if (Student == null)
		{
			Console.WriteLine("Student not found (used Get request in Edit Model)");
			return NotFound();
		}
		return Page();
	}

	public IActionResult OnPost()
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

		var existingStudent = StudentStore.Students.FirstOrDefault(student => student.Id == Student.Id);
		if (existingStudent == null)
		{
			Console.WriteLine("Student not found (stored user)");
			return NotFound();
		}
		existingStudent.FirstName = Student.FirstName;
		existingStudent.LastName = Student.LastName;
		existingStudent.Age = Student.Age;
		Console.WriteLine("Update successful");

		return RedirectToPage("/Index");
	}
}