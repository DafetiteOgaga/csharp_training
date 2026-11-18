using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NewAppWDB.Data;
using NewAppWDB.Models;
using NewAppWDB.Interfaces;

namespace NewAppWDB.Pages;

public class IndexModel : PageModel
{
    private readonly IStudentService _studentService;
    public IndexModel(IStudentService studentService)
    {
        _studentService = studentService;
    }
    public List<Student> NewRecord { get; set; } = new();
    public string ApplicationName = "Student Management Systems";
    public int TotalStudents = 0;

    public async Task OnGetAsync()
    {
        Console.WriteLine("Home request");
        NewRecord = await _studentService.GetStudentsAsync();
        // Console.WriteLine($"first name: {NewRecord[0].FirstName}");
    }
}
