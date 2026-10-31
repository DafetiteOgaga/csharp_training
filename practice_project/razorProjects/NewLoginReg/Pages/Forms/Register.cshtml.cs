using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using NewLoginReg.Pages;

namespace NewLoginReg.Pages.Forms;

public class RegisterPage : PageModel
{
	[BindProperty]
	public RegisterDetails RegisterProp { get; set; } = new();

	public void OnGet()
	{
		Console.WriteLine("Fetching from resource: register");
	}

	public IActionResult OnPost()
	{
		Console.WriteLine("Posting to resource");
		if (!ModelState.IsValid)
		{
			Console.WriteLine("post failed due to invalid data");
			return Page();
		}

		Console.WriteLine("registration data is valid");
		Console.WriteLine("saving data");

		Console.WriteLine($"registration count (before): {SharedClass.SharedRegisterObject.Count}");

		SharedClass.SharedRegisterObject.Add(new RegisterDetails {
			FirstName = RegisterProp.FirstName,
			LastName = RegisterProp.LastName,
			Age = RegisterProp.Age,
			Department = RegisterProp.Department,
		});
		Console.WriteLine($"registration count (after): {SharedClass.SharedRegisterObject.Count}");

		SharedClass.SharedRegisterSubmissionVariable = true;

		Console.WriteLine("Registration successful");

		return RedirectToPage("/Index");
	}
}

public class RegisterDetails {
	[Required(ErrorMessage = "First name is required")]
	[StringLength(100)]
	[Display(Name ="First name:")]
	public string FirstName { get; set; } = string.Empty;

	[Required(ErrorMessage = "Last name is required")]
	[StringLength(100)]
	[Display(Name ="Last name:")]
	public string LastName { get; set; } = string.Empty;

	[Required(ErrorMessage = "Age is required")]
	[Range(1, 150)]
	[Display(Name = "Age:")]
	public int? Age { get; set; }

	[Required(ErrorMessage = "Department is required")]
	[StringLength(100)]
	[Display(Name ="Department:")]
	public string Department { get; set; } = string.Empty;
}