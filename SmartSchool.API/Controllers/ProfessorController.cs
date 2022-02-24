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

        private readonly IRepository _repository;

        public ProfessorController(IRepository repository)
        {
            _repository = repository;

        }

        [HttpGet]
        public IActionResult Get()
        {
            var result = _repository.GetAllProfessores(true);

            return Ok(result);
        }

        [HttpGet("{id:int}")]
        public IActionResult GetById(int id)
        {
            var prof = _repository.GetProfessoreById(id);
            if (prof == null)
                return BadRequest("Professor não encontrado");
            return Ok(prof);
        }

        // [HttpGet("{nome}")]
        // public IActionResult GetByName(string nome)
        // {
        //     var prof = _dataContext.Professores.FirstOrDefault(p => p.Nome == nome);
        //     if (prof == null)
        //         return BadRequest("Professor não encontrado!");
        //     return Ok(prof);
        // }

        [HttpPost]
        public IActionResult Post(Professor professor)
        {
            _repository.Add(professor);
            if (_repository.SaveChanges())
                return Ok($"{professor.Nome} adicionado com sucesso");

            return BadRequest("Professor não foi salvo!");
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, Professor professor)
        {
            var prof = _repository.GetProfessoreById(id);
            if (prof == null)
                return Ok($"Professor não existe!");

            _repository.Update(professor);
            if (_repository.SaveChanges())
                return Ok($"Atualizado com sucesso para {professor.Nome}.");


            return BadRequest("Professor não atializado!");


        }

        [HttpPatch("{id}")]
        public IActionResult Patch(int id, Professor professor)
        {
            var prof = _repository.GetProfessoreById(id);
            if (prof == null)
                return BadRequest("Professor não encontrado!");

            _repository.Update(professor);
            if (_repository.SaveChanges())
                return Ok($"Atualizado com sucesso para {professor.Nome}.");


            return BadRequest("Professor não atualizado!");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var prof = _repository.GetProfessoreById(id);
            if (prof == null)
                return BadRequest("Professor não existe!");

            _repository.Delete(prof);
            if (_repository.SaveChanges())
                return Ok("Professor deletado com sucesso!");

            return Ok($"{prof.Nome} excluído com sucesso");

        }



    }
}