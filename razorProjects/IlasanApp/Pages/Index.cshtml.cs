using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using IlasanApp.Interfaces;
using IlasanApp.Services;
using IlasanApp.Models;

namespace IlasanApp.Pages;

public class IndexModel : PageModel
{
    public readonly IStudentService _studentService;
    public IndexModel(IStudentService studentService)
    {
        _studentService = studentService;
    }

    public List<Student> StudentRecords { get; set; } = new();
    public async Task OnGetAsync()
    {
        StudentRecords = await _studentService.GetStudentsAsync();
    }
}
