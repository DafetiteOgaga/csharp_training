

using System.ComponentModel.DataAnnotations;

namespace IlasanApp.Models;

public class Student
{
	public int Id { get; set; }

	[Required(ErrorMessage = "First name is required")]
	[StringLength(30, MinimumLength = 3)]
	[Display(Name ="First Name:")]
	public string FirstName { get; set; } = string.Empty;

	[StringLength(30, MinimumLength = 3)]
	[Display(Name ="Last Name:")]
	public string? LastName { get; set; } = string.Empty;

	[Required(ErrorMessage = "Email is required")]
	[EmailAddress(ErrorMessage ="Incorrect Email. Pls, use a real format")]
	[Display(Name = "Email:")]
	public string Email { get; set; } = string.Empty;

	[Required(ErrorMessage = "Phone number is required")]
	[StringLength(15, MinimumLength = 7)]
	[Phone(ErrorMessage = "Pls, enter a valid phone format")]
	[Display(Name = "Phone Number:")]
	public string Phone { get; set; } = string.Empty;

	[Required(ErrorMessage = "Age is required")]
	[Range(18, 120, ErrorMessage ="Age must be between 18 and 120")]
	[Display(Name ="Age:")]
	public int? Age { get; set; }

	[Required(ErrorMessage = "Department is required")]
	[StringLength(50, MinimumLength = 3)]
	[Display(Name ="Department:")]
	public string Department { get; set; } = string.Empty;

}