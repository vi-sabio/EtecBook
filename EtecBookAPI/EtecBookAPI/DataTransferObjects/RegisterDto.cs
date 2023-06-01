using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EtecBookAPI.DataTransferObjects
{
    public class RegisterDto
    {

        [Required(ErrorMessage = "Informe o Nome")]
        [StringLength(60,ErrorMessage = "O Nome deve possuir no máximo de 60 Caracteres")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email requerido")]
        [EmailAddress(ErrorMessage = "Informe um Email válido")]
        [StringLength(100,ErrorMessage = "O Email deve possuir no máximo de 100 Caracteres")]
        public string Email { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "A Senha é requerida")]
        [StringLength(20,MinimumLength = 6,ErrorMessage = "O Email  deve possuir no minimo 6 e no máximo de 20 Caracteres")]
        public string Password { get; set; }
    }
}