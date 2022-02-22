using SmartSchool.API.Models;
using Microsoft.EntityFrameworkCore;

namespace SmartSchool.API.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Professor> Professores { get; set; }
        public DbSet<Disciplina> Disciplinas { get; set; }
        public DbSet<AlunoDisciplina> AlunosDisciplinas { get; set; }
    }
}