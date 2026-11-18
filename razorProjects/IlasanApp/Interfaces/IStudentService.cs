using IlasanApp.Models;

namespace IlasanApp.Interfaces;

public interface IStudentService
{
	Task<List<Student>> GetStudentsAsync();
	Task<Student?> GetStudentByIdAsync(int id);
	Task AddStudentAsync(Student student);
	Task UpdateStudentAsync(Student student);
	Task DeleteStudentAsync(int id);
}