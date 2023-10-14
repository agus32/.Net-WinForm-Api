using Microsoft.EntityFrameworkCore;
using WinFormApi.Models;

namespace WinFormApi.Context
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) { }
        public DbSet <Alumno> Alumnos { get; set; }
    }
}
