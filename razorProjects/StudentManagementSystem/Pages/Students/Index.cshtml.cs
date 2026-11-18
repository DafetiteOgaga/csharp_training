using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace StudentManagementSystem.Pages.Students;

public class IndexModel : PageModel
{
	public List<StudentInput> Students { get; set; } = new();

    public void OnGet()
    {
        Students = StudentStore.Students;
    }
	// public List<string> Students { get; set; } = new();
	// public string NoStudents = "No students have been registered yet.";
	// public void OnGet()
	// {
	// 	Students = new List<string>
	// 	{
	// 		"David Okafor",
	// 		"Mary Johnson",
	// 		"Peter Adewale",
	// 		"Grace Williams"
	// 	};
	// }
}