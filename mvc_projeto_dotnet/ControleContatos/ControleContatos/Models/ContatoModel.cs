using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControleContatos.Models
{
    public class ContatoModel
    {
        public int Id { get; set; }
        
        [Required(ErrorMessage = "Insira o NOME do contato!")]
        public string Nome { get; set; }
        
        [Required(ErrorMessage = "Insira o E-MAIL do contato!")]
        [EmailAddress(ErrorMessage = "Endereço de E-MAIL Inválido!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Insira o TELEFONE do contato!")]
        [Phone(ErrorMessage = "N° de TELEFONE Inválido!")]
        public string Telefone { get; set; }

    }
}
