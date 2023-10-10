using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace CarShop.Models
{
    public class Note
    {
        public int Id { get; set; }

        [Display(Name = "Número")]
        public int Number { get; set; }

        [Display(Name = "Data Emissão")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime EmissionDate { get; set; }

        [Display(Name = "Garantia")]
        public string Warranty { get; set; }

        [Display(Name = "Valor")]
        public int Value { get; set; }

        /* Define uma relação com Cliente */
        public int ClientId { get; set; }

        [Display(Name = "Cliente")]
        public Client Client { get; set; }

        /* Define uma relação com Vendedor */
        public int SellerId { get; set; }

        [Display(Name = "Vendedor")]
        public Seller Seller { get; set; }

        /* Define uma relação com Carro */
        public int CarId { get; set; }

        [Display(Name = "Carro")]
        public Car Car { get; set; }

    }
}
