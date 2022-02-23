using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmartSchool.API.Data;
using SmartSchool.API.Models;

namespace SmartSchool.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProfessorController : ControllerBase
    {
        private readonly DataContext _dataContext;

        public ProfessorController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_dataContext.Professores);
        }

        [HttpGet("{id:int}")]
        public IActionResult GetById(int id)
        {
            var prof = _dataContext.Professores.FirstOrDefault(p => p.Id == id);
            if (prof == null)
                return BadRequest("Professor não encontrado");
            return Ok(prof);
        }

        [HttpGet("{nome}")]
        public IActionResult GetByName(string nome)
        {
            var prof = _dataContext.Professores.FirstOrDefault(p => p.Nome == nome);
            if(prof == null)
                return BadRequest("Professor não encontrado!");
            return Ok(prof);
        }

        [HttpPost]
        public IActionResult Post(Professor professor)
        {
            _dataContext.Add(professor);
            _dataContext.SaveChanges();

            return Ok($"{professor.Nome} adicionado com sucesso");
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, Professor professor)
        {
            var prof = _dataContext.Professores.AsNoTracking().FirstOrDefault(p => p.Id == id);
            if(prof == null)
                return BadRequest("Professor não existe!");
            
            _dataContext.Update(professor);
            _dataContext.SaveChanges();
            
            return Ok($"{prof.Nome} editado com sucesso");

        }

        [HttpPatch("{id}")]
        public IActionResult Patch(int id, Professor professor)
        {
            var prof = _dataContext.Professores.AsNoTracking().FirstOrDefault(p => p.Id == id);
            if(prof == null)
                return BadRequest("Professor não encontrado!");

            _dataContext.Update(professor);
            _dataContext.SaveChanges();

            return Ok($"{prof.Nome} editado com sucesso");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var prof = _dataContext.Professores.FirstOrDefault(p => p.Id == id);
            if(prof == null)
                return BadRequest("Professor não existe!");
            _dataContext.Remove(prof);
            _dataContext.SaveChanges();

            return Ok($"{prof.Nome} excluído com sucesso");

        }



    }
}