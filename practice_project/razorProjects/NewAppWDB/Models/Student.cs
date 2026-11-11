using System.ComponentModel.DataAnnotations;

namespace NewAppWDB.Models;

public class Student
{
	public int Id { get; set; }

	[Required]
	[StringLength(50, MinimumLength = 2)]
	public string FirstName { get; set; } = string.Empty;

	[Required]
	[StringLength(50, MinimumLength = 2)]
	public string LastName { get; set; } = string.Empty;

	[Required]
	[Range(1, 100)]
	public int? Age { get; set; }
}