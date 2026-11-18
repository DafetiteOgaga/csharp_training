

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using InterviewLogin.Pages;

namespace InterviewLogin.Pages.Login;

public class LoginModel : PageModel
{
	[BindProperty]
	public LoginDetails LoginProp { get; set; } = new();
	public void OnGet()
	{
		Console.WriteLine("Fetching resource (GET)");
	}

	public IActionResult OnPost()
	{
		Console.WriteLine("Sending to resource (POST)");
		if (!ModelState.IsValid)
		{
			Console.WriteLine("Oopsy! post invalid.");
			return Page();
		}

		Console.WriteLine("post is valid!");
		SharedDataStatClass.SharedEmail = LoginProp.Email;

		Console.WriteLine("Redirecting to welcome page with shared data.");
		return RedirectToPage("/Index");
	}
}

public class LoginDetails
{
	[Required(ErrorMessage = "Email is required")]
	[EmailAddress(ErrorMessage = "Please, provide a valid email address")]
	[Display(Name = "Email address:")]
	[StringLength(250)]
	public string Email { get; set; } = string.Empty;

	[Required(ErrorMessage = "Please, enter your password")]
	[DataType(DataType.Password)]
	[Display(Name = "Password:")]
	public string Password { get; set; } = string.Empty;
}
