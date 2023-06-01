using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EtecBookAPI.DataTransferObjects;

public class LoginDto
{
    [Required(ErrorMessage = "Email ou Nome de Usuario requerido")]
    public string Email { get; set; }

    [DataType(DataType.Password)]
    [Required(ErrorMessage = "A Senha é requerida")]
    public string Password { get; set; }
}
