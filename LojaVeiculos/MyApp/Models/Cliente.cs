using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace MyApp.Models
{
    public class Cliente
    {

        public int Id { get; set; }


        [Required(ErrorMessage = "Preenchimento obrigatório!")]
        [Display(Name = "Nome do Cliente")]
        public string Nome { get; set; }


        [Required(ErrorMessage = "Preenchimento obrigatório!")]
        [RegularExpression("^[^@\\s]+@[^@\\s]+\\.(com|org|net|gov)$", ErrorMessage = "Email Inválido")]
        public string Email { get; set; }


        [Required(ErrorMessage = "Preenchimento obrigatório!")]
        [RegularExpression("^\\((?:[14689][1-9]|2[12478]|3[1234578]|5[1345]|7[134579])\\) (?:[2-8]|9[1-9])[0-9]{3}\\-[0-9]{4}$", ErrorMessage = "Contato Iválido")]
        public string Contato { get; set; }


        [Required(ErrorMessage = "Preenchimento obrigatório!")]
        [Display(Name = "Veículo desejado")]
        public string Desejo { get; set; }

    }
}
