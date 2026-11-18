using System.ComponentModel.DataAnnotations;

namespace NewAppWDB.Models;

public class Student
{
	public int Id { get; set; }

	[Required(ErrorMessage ="First Name is required")]
	[StringLength(50, MinimumLength = 2)]
	[Display(Name ="First Name:")]
	public string FirstName { get; set; } = string.Empty;

	[Required(ErrorMessage ="Last Name is required")]
	[StringLength(50, MinimumLength = 2)]
	[Display(Name ="Last Name:")]
	public string LastName { get; set; } = string.Empty;

	[Required(ErrorMessage ="Age is required")]
	[Range(1, 100)]
	[Display(Name ="Age:")]
	public int? Age { get; set; }
}