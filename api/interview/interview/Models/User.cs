using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace interview.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo nome é obrigatório")]
        [MaxLength(60, ErrorMessage = "O campo nome deve conter entre 6 e 60 caracteres")]
        [MinLength(6, ErrorMessage = "O campo nome deve conter entre 6 e 60 caracteres")]
        public string Name { get; set; }

        [Required(ErrorMessage = "O campo senha é obrigatório")]
        [MaxLength(20, ErrorMessage = "O campo senha deve conter entre 6 e 20 caracteres")]
        [MinLength(6, ErrorMessage = "O campo senha deve conter entre 6 e 20 caracteres")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "O campo email é obrigatório")]
        [MaxLength(100, ErrorMessage = "O campo email deve conter entre 6 e 100 caracteres")]
        [MinLength(6, ErrorMessage = "O campo email deve conter entre 6 e 100 caracteres")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "O campo telefone é obrigatório")]
        [MaxLength(20, ErrorMessage = "O campo telefone deve conter entre 6 e 20 caracteres")]
        [MinLength(6, ErrorMessage = "O campo telefone deve conter entre 6 e 20 caracteres")]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }

        [Required(ErrorMessage = "O campo data de nascimento é obrigatório")]
        [DataType(DataType.Date)]
        public DateTime Birthdate { get; set; }
        public int AddressId { get; set; }
        public Address Address { get; set; }
    }
}
