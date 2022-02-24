using SmartSchool.API.Models;

namespace SmartSchool.API.Data
{
    public interface IRepository
    {
        void Add<T>(T entity) where T : class;
        void Update<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
        bool SaveChanges();

        Aluno[] GetAllAlunos(bool include = false);
        Aluno[] GetAllAlunosByDisciplinaId(int id, bool include = false);
        Aluno GetAlunoById(int id, bool include = false);
        Professor[] GetAllProfessores(bool include = false);
        Professor[] GetAllProfessoresByDisciplinaId(int id, bool include = false);
        Professor GetProfessoreById(int id, bool include = false);
    }
}