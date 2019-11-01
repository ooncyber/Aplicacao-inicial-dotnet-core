using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Professor>().HasData(
                new List<Professor>(){
                    new Professor(){
                        Id= 1,
                        Nome = "Prof Paula"
                    },
                    new Professor{
                        Id=2,
                        Nome = "Prof Fernando"
                    }
                }
            );

            builder.Entity<Aluno>().HasData(
                new List<Aluno>(){
                    new Aluno(){
                        Id= 1,
                        Nome = "Maria",
                        Sobrenome = "Das Dores",
                        DataNasc= "12/10/2019",
                        ProfessorId= 1
                    },
                    new Aluno{
                        Id=2,
                        Nome = "João",
                        Sobrenome = "Pedro",
                        DataNasc= "10/04/2010",
                        ProfessorId= 1
                    },
                    new Aluno{
                        Id=3,
                        Nome = "Gabriel",
                        Sobrenome = "Rodrigues",
                        DataNasc= "10/10/2010",
                        ProfessorId= 1
                    },
                    new Aluno{
                        Id=4,
                        Nome = "Rodrigues",
                        Sobrenome = "Carneiro",
                        DataNasc= "05/07/1998",
                        ProfessorId= 1
                    }
                }
            );
        }

        public DbSet<Aluno> Alunos {get;set;}
        public DbSet<Professor> Professores {get;set;}
    }
}