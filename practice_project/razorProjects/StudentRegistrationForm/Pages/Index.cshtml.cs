using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StudentRegistrationForm.Pages.Forms;

namespace StudentRegistrationForm.Pages;

public class IndexModel : PageModel
{
    public List<StudentDetails> DisplayStudentsDetails { get; set; } = new();
    public bool DisplaySuccess { get; set; }
    public void OnGet()
    {
        DisplayStudentsDetails = SharedDataClass.SharedStudentDetails;
        DisplaySuccess = SharedDataClass.SharedStudentSubmittedVariable;

        SharedDataClass.SharedStudentSubmittedVariable = false;
    }
}
