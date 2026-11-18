using NewAppWDB.Models;

namespace NewAppWDB.Data;

public static class StudentStore
{
	private static int _nextId = 1;
	public static List<Student> Students { get; } = new();

	public static void AddStudent(Student student)
	{
		student.Id = _nextId;
		_nextId++;

		Students.Add(student);
	}
}