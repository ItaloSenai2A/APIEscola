using APIEscola.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace APIEscola.Data
{
    public class APIEscolaContext : IdentityDbContext // Herança do TdentityDbContext para autenticação
    {
        public APIEscolaContext(DbContextOptions<APIEscolaContext> options) : base(options)
        { }

        // Propriedades para cada tabela 
        public DbSet<Aluno> Alunos { get; set; } // Tabela de Alunos
        public DbSet<Curso> Cursos { get; set; } // Tabela de Cursos
        public DbSet<Turma> Turmas { get; set; } // Tabela de Cursos
        public DbSet<Matricula> Matriculas { get; set; } // Tabela de Matriculas
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Chama o método OnModelCreating da classe base para a criação das tabelas padrão
            base.OnModelCreating(modelBuilder);
            // Configurar a criação de tabela adicionais aqui
            modelBuilder.Entity<Aluno>().ToTable("Alunos"); // Nome da tabela Alunos
            modelBuilder.Entity<Curso>().ToTable("Cursos"); // Nome da tabela Cursos
            modelBuilder.Entity<Turma>().ToTable("Turmas"); // Nome da tabela Cursos
            modelBuilder.Entity<Matricula>().ToTable("Matriculas"); // Nome da tabela Matriculas
        }
    }
}
