using System.ComponentModel.DataAnnotations;

namespace BancoNix.TransferenciaAPI.API
{
    public class TransferenciaDTO
    {
        [Required(ErrorMessage = "O Id da transferência é obrigatório")]
        public int id { get; set; }
        public int usuario_id { get; set; }

        [Required(ErrorMessage = "O Nome do Pagador é obrigatório")]
        [StringLength(maximumLength: 128, ErrorMessage = "O campo de Nome do Pagador deve ter no máximo 128 caracteres.")]
        public string pagador_nome { get; set; }
        [StringLength(maximumLength: 3, ErrorMessage = "O campo de Nome do Pagador deve ter no máximo 3 caracteres.")]
        public string pagador_banco { get; set; }
        [Required(ErrorMessage = "O campo de Agência do Pagador é obrigatória")]
        [StringLength(maximumLength: 4, ErrorMessage = "O campo de Agência do Pagador deve ter no máximo 4 caracteres.")]
        public string pagador_agencia { get; set; }
        [Required(ErrorMessage = "O campo de Conta do Pagador é obrigatória")]
        [StringLength(maximumLength: 6, ErrorMessage = "O campo de Conta do Pagador deve ter no máximo 6 caracteres.")]
        public string pagador_conta { get; set; }

        [Required(ErrorMessage = "O campo de Nome do Beneficiário é obrigatório")]
        [StringLength(maximumLength: 128, ErrorMessage = "O campo de Nome do Beneficiário deve ter no máximo 128 caracteres.")]
        public string beneficiario_nome { get; set; }
        [StringLength(maximumLength: 3, ErrorMessage = "O campo de Banco do Beneficiário deve ter no máximo 3 caracteres.")]
        public string beneficiario_banco { get; set; }
        [Required(ErrorMessage = "O campo de  Agência do Beneficiário é obrigatória")]
        [StringLength(maximumLength: 4, ErrorMessage = "O campo de Nome do Beneficiário deve ter no máximo 4 caracteres.")]
        public string beneficiario_agencia { get; set; }
        [Required(ErrorMessage = "O campo de Conta do Beneficiário é obrigatória")]
        [StringLength(maximumLength: 6, ErrorMessage = "O campo de Nome do Beneficiário deve ter no máximo 6 caracteres.")]
        public string beneficiario_conta { get; set; }

        [Required(ErrorMessage = "O campo de Valor da transferência é obrigatório")]
        [Range(0.00, 9999999999999.00, ErrorMessage = "O campo de Nome do Beneficiário deve ter no máximo 6 caracteres.")]

        public decimal valor { get; set; }
        [StringLength(maximumLength: 4, ErrorMessage = "O campo de Tipo deve ter no máximo 6 caracteres.")]

        public string tipo { get; set; }
        [StringLength(maximumLength: 12, ErrorMessage = "O campo de Status deve ter no máximo 12 caracteres.")]

        public string status { get; set; }
    }
}