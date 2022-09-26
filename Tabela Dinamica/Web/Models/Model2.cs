using System.ComponentModel;

namespace Web.Models
{
    public class Model2
    {
        public int Id { get; set; }

        [DisplayName("Coluna 1")]
        public string? Coluna1 { get; set; }

        [DisplayName("Coluna 2")]
        public string? Coluna2 { get; set; }

        [DisplayName("Coluna 3")]
        public string? Coluna3 { get; set; }

    }
}
