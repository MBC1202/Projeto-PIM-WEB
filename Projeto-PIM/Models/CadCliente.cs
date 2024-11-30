//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Projeto_PIM.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;


    public partial class CadCliente
    {
        public int Id { get; set; }
        public string NomeFull { get; set; }
        public string Email { get; set; }
        [Required(ErrorMessage = "A senha � obrigat�ria.")]
        [MinLength(6, ErrorMessage = "A senha deve ter no m�nimo 6 caracteres.")]
        [StringLength(100, MinimumLength = 6, ErrorMessage = "A senha deve ter entre 6 e 100 caracteres.")]
        public string Senha { get; set; }
        [Required(ErrorMessage = "O CPF � obrigat�rio.")]
        [RegularExpression(@"^\d{11}$", ErrorMessage = "CPF deve conter 11 d�gitos.")]
        public string CPF { get; set; }
        public string Telefone { get; set; }
        public string CEP { get; set; }
        public Nullable<int> Numero { get; set; }
        public string Complemento { get; set; }
        public string Rua { get; set; }
    }
}
