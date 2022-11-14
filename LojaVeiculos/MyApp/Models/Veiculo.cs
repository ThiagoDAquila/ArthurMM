using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace MyApp.Models
{
    public class Veiculo
    {
        public int Id { get; set; }

        [Display(Name = "Modelo do Veículo")]
        public string Modelo { get; set; }
        public string Cor { get; set; }

        [Range(2000, 2023, ErrorMessage = "Por favor, informe um ano válido! (2000 - 2023)")]
        public int Ano { get; set; }
        public int Quilometragem { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:C}")]
        public double Valor { get; set; }
    }
}