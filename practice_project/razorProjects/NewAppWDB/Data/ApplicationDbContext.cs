using Microsoft.EntityFrameworkCore;
using NewAppWDB.Models;

namespace NewAppWDB.Data;

public class ApplicationDbContext : DbContext
{
	public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
		: base(options)
	{
	}

	public DbSet<Student> Students { get; set; }
}