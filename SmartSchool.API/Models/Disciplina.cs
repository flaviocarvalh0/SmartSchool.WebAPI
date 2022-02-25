using System.Collections.Generic;

namespace SmartSchool.API.Models
{
    public class Disciplina
    {
        public Disciplina() { }



        //DISCIPLINA
        public Disciplina(int id, string nome, int professorId, int cursoId)
        {
            this.Id = id;
            this.Nome = nome;
            this.ProfessorId = professorId;
            this.CursoId = cursoId;


        }
        public int Id { get; set; }
        public string Nome { get; set; }
        public int CargaHoraria { get; set; }
        public int? PreRequisitoId { get; set; } = null;
        public Disciplina PreRequisito { get; set; }

        //PROFESSOR
        public int ProfessorId { get; set; }
        public Professor Professor { get; set; }


        //CURSO
        public int CursoId { get; set; }
        public Curso curso { get; set; }

        public IEnumerable<AlunoDisciplina> AlunosDisciplinas { get; set; }
    }
}