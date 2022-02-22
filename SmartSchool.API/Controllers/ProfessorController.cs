using Microsoft.AspNetCore.Mvc;
using SmartSchool.API.Models;

namespace  SmartSchool.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProfessorController : ControllerBase
    {

        public List<Professor> Professores = new List<Professor>()
        {
            new Professor()
            {
                Id = 1,
                Nome = "Chico"
            },
            new Professor()
            {
                Id = 2,
                Nome = "Adson"
            },
            new Professor()
            {
                Id = 3,
                Nome = "Suzana"
            }
        };
        public ProfessorController(){}

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(Professores);
        }


    }
}