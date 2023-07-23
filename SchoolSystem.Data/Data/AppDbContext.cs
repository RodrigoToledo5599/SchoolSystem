using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SchoolSystem.Models.Models;

namespace SchoolSystem.Data.Data
{
    public class AppDbContext : Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet <Aluno> Alunos { get; set; }
        public DbSet <Turma> Turmas { get; set; }
        //public DbSet <Materia> Materias { get; set; }
        public DbSet<Atividade> Atividades { get; set; }
         

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<Aluno>().HasData(
                new Aluno { Id = 1, Matricula = "222", Senha = "2", Serie = 3, Name = "Rodrigo"},
                new Aluno { Id = 2, Matricula = "333", Senha = "3", Serie = 3, Name = "Ronaldo"},
                new Aluno { Id = 3, Matricula = "444", Senha = "4", Serie = 5, Name = "Manuela"},
                new Aluno { Id = 4, Matricula = "555", Senha = "5", Serie = 2, Name = "Fernando"}


                );
            

            modelBuilder.Entity<Turma>().HasData(
                new Turma { Id = 1, Name="11" },
                new Turma { Id = 2, Name="12" },
                new Turma { Id = 3, Name="13" },
                new Turma { Id = 4, Name="21" },
                new Turma { Id = 5, Name="22" },
                new Turma { Id = 6, Name="23" },
                new Turma { Id = 7, Name="31" },
                new Turma { Id = 8, Name="32" },
                new Turma { Id = 9, Name="33" },
                new Turma { Id = 10, Name="41" },
                new Turma { Id = 11, Name="42" },
                new Turma { Id = 12, Name="43" },
                new Turma { Id = 13, Name="51" },
                new Turma { Id = 14, Name="52" },
                new Turma { Id = 15, Name="53" }




                );




            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }

        }


         

	}
}
