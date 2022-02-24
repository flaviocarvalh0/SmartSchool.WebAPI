using Microsoft.EntityFrameworkCore;
using SmartSchool.API.Models;

namespace SmartSchool.API.Data
{
    public class Repository : IRepository
    {
        private readonly DataContext _dataContext;
        public Repository(DataContext dataContext)
        {
            _dataContext = dataContext;

        }
        public void Add<T>(T entity) where T : class
        {
            _dataContext.Add(entity);
        }
        public void Update<T>(T entity) where T : class
        {
            _dataContext.Update(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            _dataContext.Remove(entity);
        }

        public bool SaveChanges()
        {
            return (_dataContext.SaveChanges() > 0);
        }

        // ALUNOS
        public Aluno[] GetAllAlunos(bool include = false)
        {
            IQueryable<Aluno> query = _dataContext.Alunos;

            if (include)
            {
                query = query.Include(a => a.AlunosDisciplinas)
                                .ThenInclude(ad => ad.Disciplina)
                                .ThenInclude(p => p.Professor);
            }

            query = query.AsNoTracking().OrderBy(a => a.Id);

            return query.ToArray();
        }

        public Aluno[] GetAllAlunosByDisciplinaId(int id, bool include = false)
        {
            IQueryable<Aluno> query = _dataContext.Alunos;
            if (include)
            {
                query = query.Include(a => a.AlunosDisciplinas)
                                .ThenInclude(ad => ad.Disciplina)
                                .ThenInclude(p => p.Professor);
            }

            query = query.AsNoTracking()
                            .OrderBy(a => a.Id)
                            .Where(aluno => aluno.AlunosDisciplinas
                            .Any(ad => ad.DisciplinaId == id));

            return query.ToArray();

        }

        public Aluno GetAlunoById(int id, bool include = false)
        {
            IQueryable<Aluno> query = _dataContext.Alunos;

            if (include)
            {
                query = query.Include(a => a.AlunosDisciplinas)
                                .ThenInclude(ad => ad.Disciplina)
                                .ThenInclude(p => p.Professor);
            }

            query = query.AsNoTracking()
                            .OrderBy(a => a.Id)
                            .Where(aluno => aluno.Id == id);

            return query.FirstOrDefault();
        }



        //PROFESSORES

        public Professor[] GetAllProfessores(bool include = false)
        {
            IQueryable<Professor> query = _dataContext.Professores;

            if (include)
            {
                query = query.Include(ad => ad.Disciplinas)
                                        .ThenInclude(a => a.AlunosDisciplinas)
                                        .ThenInclude(al => al.Aluno);
            }

            query = query.AsNoTracking().OrderBy(p => p.Id);

            return query.ToArray();
        }

        public Professor[] GetAllProfessoresByDisciplinaId(int id, bool include = false)
        {
            IQueryable<Professor> query = _dataContext.Professores;

            if (include)
            {
                query = query.Include(ad => ad.Disciplinas)
                                        .ThenInclude(a => a.AlunosDisciplinas)
                                        .ThenInclude(al => al.Aluno);
            }

            query = query.AsNoTracking().OrderBy(p => p.Id)
                                        .Where(prof => prof.Disciplinas
                                        .Any(d => d.AlunosDisciplinas
                                        .Any(ad => ad.DisciplinaId == id)));


            return query.ToArray();
        }

        public Professor GetProfessoreById(int id, bool include = false)
        {
            IQueryable<Professor> query = _dataContext.Professores;

            if (include)
            {
                query = query.Include(ad => ad.Disciplinas)
                                        .ThenInclude(a => a.AlunosDisciplinas)
                                        .ThenInclude(al => al.Aluno);
            }

            query = query.AsNoTracking().OrderBy(p => p.Id)
                                        .Where(p => p.Id == id);

            return query.FirstOrDefault();
        }
    }
}