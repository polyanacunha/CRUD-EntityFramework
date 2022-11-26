using aula2611.Data;
using aula2611.Models;
using System.Linq;

internal class Program
{
    private static void Main(string[] args)
    {
        Inserir();
        Atualizar();
        Deletar();
        Console.WriteLine("Hello, World!");
    }
     
    public static void Inserir(){
          
       var context = new aula2611DataContext();
       
        var aluno = new Aluno { Nome = "Poly", Email = "poly@gmail.com", CPF = "123456789" };
        
        context.Alunos.Add(aluno);


        // var Curso = new Curso { Id = 2, Autor = "Poly", Categoria = "EAD"};
       // context.Cursos.Add(curso);


        //var AlunoCurso = new AlunoCurso { Id = "2", Autor = "Poly", Categoria = "EAD"};
        //context.AlunoCursos.Add(alunoCurso);


        context.SaveChanges();
    }

     public static void Atualizar(){
         var context = new aula2611DataContext();

         var aluno = context.Alunos.FirstOrDefault(x => x.Id == 1);
         aluno.Nome = "Mirela";
         aluno.Email = "artes@gmail.com";
         aluno.CPF = "12345678987";

         context.Update(aluno);
         context.SaveChanges();

        
     }

public static void Deletar(){
     var context = new aula2611DataContext();

     var aluno = context.Alunos.FirstOrDefault(x => x.Id == 1);
     context.Remove(aluno);
     context.SaveChanges();

}

    }


