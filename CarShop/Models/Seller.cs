using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace CarShop.Models
{
    public class Seller
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [Display(Name = "Data Admissão")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime AdmissionDate { get; set; }

        [Display(Name = "Matrícula")]
        public string Registration { get; set; }
        public int Salary { get; set; }

        /* Define uma relação com Notes */
        ICollection<Note> Notes { get; set; } = new List<Note>();
    }
}
