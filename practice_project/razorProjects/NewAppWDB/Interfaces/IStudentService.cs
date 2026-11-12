using NewAppWDB.Models;

namespace NewAppWDB.Interfaces;

public interface IStudentService
{
	// public List<Student> Students { get; }
	// void AddStudent(Student student);
	Task<List<Student>> GetStudentsAsync();

    Task<Student?> GetStudentByIdAsync(int id);

    Task AddStudentAsync(Student student);

    Task UpdateStudentAsync(Student student);

    Task DeleteStudentAsync(int id);
}