using StudentRegistrationForm.Pages.Forms;
namespace StudentRegistrationForm.Pages;

public static class SharedDataClass
{
	public static bool SharedStudentSubmittedVariable { get; set; }
	public static List<StudentDetails> SharedStudentDetails { get; set; } = new();
}