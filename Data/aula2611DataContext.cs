
using aula2611.Models;
using Microsoft.EntityFrameworkCore;

namespace aula2611.Data;

public class aula2611DataContext:DbContext
{
    public DbSet<Aluno> Alunos{ get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
         options.UseSqlServer("PUT YOUR CONNECTION STRING HERE");
    }

    // protected override void OnModelCreating(ModelBuilder modelBuilder)
    // {
    //     modelBuilder.ApplyConfiguration(new AlunoMap());
    // }
    
}