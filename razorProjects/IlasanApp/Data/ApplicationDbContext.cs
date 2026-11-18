using Microsoft.EntityFrameworkCore;
using IlasanApp.Models;

namespace IlasanApp.Data;

public class ApplicationDbContext : DbContext
{
	public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
	: base(options)
	{

	}

	public DbSet<Student> Students { get; set; }
}