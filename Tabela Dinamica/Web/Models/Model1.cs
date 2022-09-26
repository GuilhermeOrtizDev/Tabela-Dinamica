using System.ComponentModel;

namespace Web.Models
{
    public class Model1
    {
        public int Id { get; set; }

        [DisplayName("Criado")]
        public DateTime? Criado { get; set; }

        [DisplayName("Modificado")]
        public DateTime? Modificado { get; set; }

        [DisplayName("Titulo")]
        public string? Titulo { get; set; }

        [DisplayName("Ativo?")]
        public bool Ativo { get; set; }
    }
}
