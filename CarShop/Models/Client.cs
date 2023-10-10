using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace CarShop.Models
{
    public class Client
    {
        public int Id { get; set; }

        [Display(Name = "Nome Completo")]
        [Required(ErrorMessage = "Campo Obrigatório"), MinLength(2), MaxLength(30)]
        public string Name { get; set; }

        [Display(Name = "Nascimento")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime BirthDate { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [Display(Name = "Telefone")]
        public string Telephone { get; set; }

        [Display(Name = "Endereço")]
        public string Adress { get; set; }
        public string Cpf { get; set; }

        /* Define uma relação com Notes */
        ICollection<Note> Notes { get; set; } = new List<Note>();
    }
}
