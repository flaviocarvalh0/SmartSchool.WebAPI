using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmartSchool.API.Data;
using SmartSchool.API.Models;

namespace SmartSchool.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AlunoController : ControllerBase
    {
        private readonly DataContext _dataContext;

        public AlunoController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        //api/aluno
        [HttpGet]
        public IActionResult Get()
        {
            return Ok( _dataContext.Alunos);
        }
        //api/aluno/id
        [HttpGet("{id:int}")]
        public IActionResult GetById(int id)
        {
            var retornaAluno = _dataContext.Alunos.FirstOrDefault(a => a.Id == id);
            if (retornaAluno == null)
                return BadRequest("Aluno não encontrado");
            return Ok(retornaAluno);
        }
        //api/aluno/nome
        [HttpGet("{nome}")]
        public IActionResult GetByName(string nome)
        {
            var retornaAluno = _dataContext.Alunos.FirstOrDefault(a => a.Nome.Contains(nome));
            if (retornaAluno == null)
                return BadRequest("Aluno não encontrado");
            return Ok(retornaAluno);
        }

        //api/aluno
        [HttpPost]
        public IActionResult Post(Aluno aluno)
        {

            _dataContext.Add(aluno);
            _dataContext.SaveChanges();

            return Ok($"{aluno.Nome} Salvo com sucesso!!");
        }

        //AsNoTracking(), quando vamos atualizar algum item, precisamos fazer a busca para ver se o item existe, porem essa busca trava e não podemos atualizalo, então usamos o AsNoTracking() para desbloquear a busca e conseguir atualizar o aluno
        [HttpPut("{id}")]
        public IActionResult Put(int id, Aluno aluno)
        {
            var al = _dataContext.Alunos.AsNoTracking().FirstOrDefault(a => a.Id == id);
            if(al == null)
                return BadRequest("Aluno não foi encontrado");

            _dataContext.Update(aluno);
            _dataContext.SaveChanges();

            return Ok($"{aluno.Nome} Atualizado com sucesso!");
        }
        [HttpPatch("{id}")]
        public IActionResult Patch(int id, Aluno aluno)
        {
            var al = _dataContext.Alunos.AsNoTracking().FirstOrDefault(a => a.Id == id);
            if(al == null)
                return BadRequest("Aluno não encontrado");

            _dataContext.Update(aluno);
            _dataContext.SaveChanges();

            return Ok($"{aluno.Nome} Atualizado com sucesso!");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var aluno = _dataContext.Alunos.FirstOrDefault(a => a.Id == id);
            if (aluno == null)
                return BadRequest("Aluno não encontrado");
            _dataContext.Remove(aluno);
            _dataContext.SaveChanges();
            return Ok($"{aluno.Nome} removido com sucesso!");
        }

    }
}