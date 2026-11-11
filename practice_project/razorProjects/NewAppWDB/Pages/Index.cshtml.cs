using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NewAppWDB.Data;
using NewAppWDB.Models;

namespace NewAppWDB.Pages;

public class IndexModel : PageModel
{
    public List<Student> NewRecord { get; set; } = new();
    public string ApplicationName = "Student Management Systems";
    public int TotalStudents = 0;

    public void OnGet()
    {
        Console.WriteLine("Home request");
        NewRecord = StudentStore.Students;
        // Console.WriteLine($"first name: {NewRecord[0].FirstName}");
    }
}
