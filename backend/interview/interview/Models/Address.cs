using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace interview.Models
{
    public class Address
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo CEP é obrigatório")]
        [DataType(DataType.PostalCode)]
        public string Cep { get; set; }

        [Required(ErrorMessage = "O campo Rua é obrigatório")]
        public string Street { get; set; }

        [Required(ErrorMessage = "O campo Bairro é obrigatório")]
        public string District { get; set; }

        [Required(ErrorMessage = "O campo Cidade é obrigatório")]
        public string City { get; set; }

        [Required(ErrorMessage = "O campo País é obrigatório")]
        public string Country { get; set; }

        [Required(ErrorMessage = "O campo Número é obrigatório")]
        public int number { get; set; }
    }
}
