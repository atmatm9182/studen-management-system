using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using System.IO;

namespace Sem2Project;

public class StudentsContext : DbContext
{
    public DbSet<Student> Students { get; set; }
    public string DbPath { get; }

    public StudentsContext()
    {
        DbPath = Path.Join(Directory.GetCurrentDirectory(), "students.db");
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options) =>
        options.UseSqlite($"Data Source={DbPath}");
}

public record Student
{
    [Key]
    public required uint AlbumNumber { get; init; }
    
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
}