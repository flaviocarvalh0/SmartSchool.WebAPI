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
        
        private readonly IRepository _repository;

        public AlunoController(IRepository repository)
        {
            _repository = repository;
            
        }


        //api/aluno
        [HttpGet]
        public IActionResult Get()
        {
            
            var result = _repository.GetAllAlunos(true);

            return Ok(result);
        }
        //api/aluno/id
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var retornaAluno = _repository.GetAlunoById(id, true);
            if (retornaAluno == null)
                return BadRequest("Aluno não encontrado");
            return Ok(retornaAluno);
        }

        //api/aluno/nome
        // [HttpGet("{nome}")]
        // public IActionResult GetByName(string nome)
        // {
        //     var retornaAluno = _dataContext.Alunos.FirstOrDefault(a => a.Nome.Contains(nome));
        //     if (retornaAluno == null)
        //         return BadRequest("Aluno não encontrado");
        //     return Ok(retornaAluno);
        // }

        //api/aluno
        [HttpPost]
        public IActionResult Post(Aluno aluno)
        {

            _repository.Add(aluno);
            if (_repository.SaveChanges())
            {
                return Ok($"{aluno.Nome} Salvo com sucesso!!");
            }

            return BadRequest("Aluno não foi salvo");


        }

        //AsNoTracking(), quando vamos atualizar algum item, precisamos fazer a busca para ver se o item existe, porem essa busca trava e não podemos atualizalo, então usamos o AsNoTracking() para desbloquear a busca e conseguir atualizar o aluno
        [HttpPut("{id}")]
        public IActionResult Put(int id, Aluno aluno)
        {
            var al = _repository.GetAlunoById(id);
            if (al == null)
                return BadRequest("Aluno não foi encontrado");

            _repository.Update(aluno);
            if (_repository.SaveChanges())
                return Ok($"Atualizado com sucesso para {aluno.Nome}.");

            return BadRequest("Aluno não atualizado");


        }
        [HttpPatch("{id}")]
        public IActionResult Patch(int id, Aluno aluno)
        {
            var al = _repository.GetAlunoById(id);
            if (al == null)
                return BadRequest("Aluno não encontrado");

            _repository.Update(aluno);
            if (_repository.SaveChanges())
                return Ok($"Atualizado com sucesso para {aluno.Nome}.");

            return BadRequest("Aluno não atualizado");


        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var aluno = _repository.GetAlunoById(id);

            _repository.Delete(aluno);
            if (_repository.SaveChanges())
                return Ok("Aluno removido com sucesso!");

            return BadRequest("Aluno não encontrado");

        }

    }
}