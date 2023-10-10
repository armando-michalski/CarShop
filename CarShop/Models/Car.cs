using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace CarShop.Models
{
    public class Car
    {
        public int Id { get; set; }

        [Display(Name = "Marca")]
        public string Brand { get; set; }

        [Display(Name = "Modelo")]
        public string Model { get; set; }

        [Display(Name = "Data Fabricação")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime FabricationDate { get; set; }

        [Display(Name = "Ano Modelo")]
        [Range(1800, 3000, ErrorMessage = "Insira um ano adequado (ex.: entre 1800 e 3000")]
        public int YearModel { get; set; }

        public int Chassi { get; set; }

        [Display(Name = "Valor")]
        public int Value { get; set; }
    }
}
