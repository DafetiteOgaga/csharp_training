
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using StudentRegistrationForm.Pages;

namespace StudentRegistrationForm.Pages.Forms;

public class RegisterStudent : PageModel
{
	[BindProperty]
	public StudentDetails Student { get; set; } = new();

	public void OnGet()
	{
		Console.WriteLine("Fetching resoure");
	}

	public IActionResult OnPost()
	{
		Console.WriteLine("Sending to resource");
		if (!ModelState.IsValid)
		{
			Console.WriteLine("Data is invalid.\nCan't send to resource");
			return Page();
		}

		Console.WriteLine($"Record count (before): {SharedDataClass.SharedStudentDetails.Count}");
		Console.WriteLine("Saving student record");
		SharedDataClass.SharedStudentDetails.Add(new StudentDetails
		{
			FirstName = Student.FirstName,
			LastName = Student.LastName,
			Username = Student.Username,
			Department = Student.Department,
			Email = Student.Email,
			Phone = Student.Phone,
		});
		SharedDataClass.SharedStudentSubmittedVariable = true;
		Console.WriteLine($"Record count (after): {SharedDataClass.SharedStudentDetails.Count}");
		Console.WriteLine($"Record submitted: {SharedDataClass.SharedStudentSubmittedVariable}");

		Console.WriteLine("Data is valid");
		return RedirectToPage("/Index");
	}
}

public class StudentDetails
{
	[Required(ErrorMessage = "Enter your first name")]
	[StringLength(100)]
	[Display(Name ="Firstname:")]
	public string FirstName { get; set; } = string.Empty;

	[Required(ErrorMessage = "Enter your last name")]
	[StringLength(100)]
	[Display(Name ="Lastname:")]
	public string LastName { get; set; } = string.Empty;

	[Display(Name = "Middlename:")]
	public string? MiddleName { get; set; }

	[Required(ErrorMessage = "You must create a unique username")]
	[StringLength(100)]
	[Display(Name ="Username:")]
	public string Username { get; set; } = string.Empty;

	[Required(ErrorMessage = "You must create a unique password")]
	[DataType(DataType.Password)]
	[Display(Name ="Password:")]
	public string Password { get; set; } = string.Empty;

	[Required(ErrorMessage = "Confirm your password")]
	[DataType(DataType.Password)]
	[Compare("Password", ErrorMessage ="The passwords do not match")]
	[Display(Name = "Confirm Password:")]
	public string ConfirmPassword { get; set; } = string.Empty;

	[Required(ErrorMessage = "Enter your department")]
	[StringLength(200)]
	[Display(Name ="Department:")]
	public string Department { get; set; } = string.Empty;

	[Required(ErrorMessage = "Enter your date of birth")]
	[DataType(DataType.Date)]
	[Display(Name = "Date of Birth:")]
	public DateOnly? DateOfBirth { get; set; }

	[Required(ErrorMessage = "Enter male or female")]
	[StringLength(100)]
	[Display(Name ="Gender:")]
	public string Gender { get; set; } = string.Empty;

	[Required(ErrorMessage = "Enter your email")]
	[EmailAddress(ErrorMessage ="Enter a valid email address")]
	[StringLength(500)]
	[Display(Name ="Email address:")]
	public string Email { get; set; } = string.Empty;
	
	[Required(ErrorMessage = "Enter your phone number")]
	[StringLength(20, MinimumLength =7, ErrorMessage ="Enter a valid phone number")]
	[Phone(ErrorMessage ="Enter a valid phone number")]
	[Display(Name = "Phone number:")]
	public string Phone { get; set; } = string.Empty;

	[Required(ErrorMessage = "Enter your home address")]
	[StringLength(1000)]
	[Display(Name ="Home Address:")]
	public string Address { get; set; } = string.Empty;

	[Required(ErrorMessage = "Enter your residential city")]
	[StringLength(200)]
	[Display(Name ="Residential city:")]
	public string City { get; set; } = string.Empty;

	[Required(ErrorMessage = "Enter your residential state")]
	[StringLength(200)]
	[Display(Name ="Residential state:")]
	public string State { get; set; } = string.Empty;

	[Required(ErrorMessage = "Enter your residential country")]
	[StringLength(200)]
	[Display(Name ="Country:")]
	public string Country { get; set; } = string.Empty;

	[Required(ErrorMessage = "Enter your nationality")]
	[StringLength(200)]
	[Display(Name ="Nationality:")]
	public string Nationality { get; set; } = string.Empty;
}
