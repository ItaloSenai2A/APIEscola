using System.ComponentModel.DataAnnotations;

namespace APIEscola.Models
{
    public class Turma
    {
        public Guid TurmaId { get; set; }

        [Required(ErrorMessage = "O Campo CursoId é Obrigatório")]
        public Guid CursoId { get; set; }

        [Required(ErrorMessage = "O Campo Data de Início é Obrigatório")]
        [DataType(DataType.Date, ErrorMessage = "A Data de Início não é válida")]
        public DateOnly DataInicio { get; set; }

        [Required(ErrorMessage = "O Campo Data de Fim é Obrigatório")]
        [DataType(DataType.Date, ErrorMessage = "A Data de Fim não é válida")]
        public DateOnly DataFim { get; set; }

        [Required(ErrorMessage = "O Campo Descrição é Obrigatório")]
        [MaxLength(255, ErrorMessage = "A Descrição deve ter no máximo 255 caracteres")]
        public string? Descricao { get; set; }

        [Required(ErrorMessage = "O Campo Sigla é Obrigatório")]
        [MaxLength(10, ErrorMessage = "A Sigla deve ter no máximo 10 caracteres")]
        public string? Sigla { get; set; }

        // Relação (opcional)
        public Curso? Curso { get; set; }
    }
}
