

namespace SmartSchool.API.Dto
{
    public class AlunoRegistrarDTO
    {
        public int Id { get; set; }
        public int Matricula { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Telefone { get; set; }
        public DateTime DataNasc { get; set; }
        public DateTime DataInic { get; set; } = DateTime.Now;
        public DateTime? DataFim { get; set; }
        public bool Ativo { get; set; } = true;

        
    }
}