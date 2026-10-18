using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace StudentManagementSystem.Pages;

public class IndexModel : PageModel
{
    public string SchoolName { get; set;} = "The Totalman schools";
    public int SchoolStudents { get; set;} = 500;
    public int SchoolTeachers { get; set;} = 18;
    public string SchoolLocation { get; set;} = "Lagos";
    public string SchoolCountry { get; set;} = "Nigeria";
    public string WelcomeMessage { get; set;} = "";

    public void OnGet()
    {
        WelcomeMessage = "Welcome to the Student Management System.";
    }
}
