using System.ComponentModel;

namespace Web.Models
{
    public class Model3
    {
        public int Id { get; set; }

        [DisplayName("Campo Composto")]
        public string? CampoComposto { get; set; }

        [DisplayName("Campo Com Acentuação")]
        public string? CampoComAcentuacao { get; set; }
    }
}
