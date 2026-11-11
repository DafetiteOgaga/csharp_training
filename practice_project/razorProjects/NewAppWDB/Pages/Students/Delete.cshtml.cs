using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NewAppWDB.Data;
using NewAppWDB.Models;

namespace NewAppWDB.Pages.Students;

public class DeleteModel : PageModel
{
	public Student? Student { get; set; }

	public IActionResult OnGet(int id)
	{
		Student = StudentStore.Students.FirstOrDefault(student => student.Id == id);

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

	public IActionResult OnPost(int id)
	{
		Console.WriteLine($"form ID: {id}");
		var student = StudentStore.Students.FirstOrDefault(student => student.Id == id);
		// var student1 = StudentStore.Students.Select(student => student.Id == id);
		// Console.WriteLine($"student1: {student1}");

		if (student == null)
		{
			Console.WriteLine($"Student: {Student}");
			Console.WriteLine("Student not found (used Post request in Delete Model)");
			return NotFound();
		}
		Console.WriteLine("Removing student record");
		StudentStore.Students.Remove(student);

		return RedirectToPage("/Index");
	}
}
