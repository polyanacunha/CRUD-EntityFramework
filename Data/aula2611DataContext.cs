
using aula2611.Models;
using Microsoft.EntityFrameworkCore;

namespace aula2611.Data;

public class aula2611DataContext:DbContext
{
    public DbSet<Aluno> Alunos{ get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        //options.UseSqlServer("Data Source=DESKTOP-7GCCS8Q\\SQLEXPRESS01;Initial Catalog=mentoria;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
         options.UseSqlServer("Data Source=usinacompany.com;User ID=usina_usr;Password=Abc54321;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
    }

    // protected override void OnModelCreating(ModelBuilder modelBuilder)
    // {
    //     modelBuilder.ApplyConfiguration(new AlunoMap());
    // }
    
}