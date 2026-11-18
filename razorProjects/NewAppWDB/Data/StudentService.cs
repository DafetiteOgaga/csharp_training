using Microsoft.EntityFrameworkCore;
using NewAppWDB.Models;
using NewAppWDB.Interfaces;

namespace NewAppWDB.Data;

public class StudentService : IStudentService
{
	private readonly ApplicationDbContext _context;

	public StudentService(ApplicationDbContext context)
	{
		_context = context;
	}

	public async Task<List<Student>> GetStudentsAsync()
	{
		return await _context.Students.ToListAsync();
	}

	public async Task<Student?> GetStudentByIdAsync(int id)
	{
		return await _context.Students.FirstOrDefaultAsync(student => student.Id == id);
	}

	public async Task AddStudentAsync(Student student)
	{
		await _context.Students.AddAsync(student);
		await _context.SaveChangesAsync();
	}

	public async Task UpdateStudentAsync(Student student)
	{
		_context.Students.Update(student);
		await _context.SaveChangesAsync();
	}

	public async Task DeleteStudentAsync(int id)
	{
		var student = await _context.Students.FindAsync(id);

		if (student is not null)
		{
			_context.Students.Remove(student);
			await _context.SaveChangesAsync();
		}
	}
}
