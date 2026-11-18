using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using NewLoginReg.Pages;

namespace NewLoginReg.Pages.Forms;

public class LoginPage : PageModel
{
	[BindProperty]
	public LoginDetails LoginProp { get; set; } = new();

	public void OnGet()
	{
		Console.WriteLine("Fetching from resource: Login");
	}

	public IActionResult OnPost()
	{
		Console.WriteLine("Posting to resource: Login");
		if (!ModelState.IsValid)
		{
			Console.WriteLine("Data is invalid: post failed");
			return Page();
		}

		Console.WriteLine("Data is valid: moving forward");
		// process data
		Console.WriteLine($"Email: {LoginProp.Email}");
		Console.WriteLine($"Password: {LoginProp.Password}");
		Console.WriteLine($"Loging in the user: {LoginProp.Email.Split("@")[0]}");
		// Console.WriteLine($"object count before: {SharedClass.SharedLoginEmail}");
		SharedClass.SharedLoginEmailName = LoginProp.Email.Split("@")[0];
		// Console.WriteLine($"object count after: {SharedClass.SharedLoginEmail}");

		Console.WriteLine("Redirecting homw");
		return RedirectToPage("/Index");
	}
}

public class LoginDetails
{
	[Required(ErrorMessage = "Email is required")]
	[EmailAddress(ErrorMessage = "Enter a valid email")]
	[Display(Name ="Email address:")]
	public string Email { get; set; } = string.Empty;

	[Required(ErrorMessage = "Password is required")]
	[DataType(DataType.Password)]
	[Display(Name ="Password:")]
	public string Password { get; set; } = string.Empty;
}