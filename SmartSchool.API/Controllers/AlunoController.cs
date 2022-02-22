using Microsoft.AspNetCore.Mvc;
using SmartSchool.API.Models;

namespace SmartSchool.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AlunoController : ControllerBase
    {

        public List<Aluno> Alunos = new List<Aluno>()
        {
            new Aluno()
            {
                Id = 1,
                Nome = "Marcos",
                Sobrenome = "Alves",
                Telefone = "(81) 9999-99999"
            },
            new Aluno()
            {
                Id = 2,
                Nome = "Lucas",
                Sobrenome = "Cavalvante",
                Telefone = "(81) 9999-99999"
            },
            new Aluno()
            {
                Id = 3,
                Nome = "Marta",
                Sobrenome = "Kent",
                Telefone = "(81) 9999-99999"
            },
        };
        public AlunoController() { }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(Alunos);
        }
        [HttpGet("{id:int}")]
        public IActionResult GetById(int id)
        {
            var retornaAluno = Alunos.FirstOrDefault(a => a.Id == id);
            if (retornaAluno == null)
                return BadRequest("Aluno não encontrado");
            return Ok(retornaAluno);
        }
        [HttpGet("{nome}")]
        public IActionResult GetByName(string nome)
        {
            var retornaAluno = Alunos.FirstOrDefault(a => a.Nome.Contains(nome));
            if (retornaAluno == null)
                return BadRequest("Aluno não encontrado");
            return Ok(retornaAluno);
        }


        [HttpPost]
        public IActionResult Post(Aluno aluno)
        {

            return Ok(aluno);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id)
        {

            return Ok(id);
        }
        [HttpPatch("{id}")]
        public IActionResult Patch(int id)
        {

            return Ok(id);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {

            return Ok(id);
        }

    }
}