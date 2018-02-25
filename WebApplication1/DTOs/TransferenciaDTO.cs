using BancoNix.TransferenciaAPI.Dominio;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace BancoNix.TransferenciaAPI.API
{
    [DataContract]
    public class TransferenciaDTO
    {
        public int id { get; set; }

        [DataMember(Name ="id")]
        [Required(ErrorMessage = "O Id da transferência é obrigatório")]
        public string id_transferencia { get; set; }

        [DataMember(Name ="pagador")]
        [Required(ErrorMessage = "O Pagador é obrigatório")]
        public virtual Usuario Pagador { get; set; }

        [DataMember(Name = "beneficiario")]
        [Required(ErrorMessage = "O Beneficiario é obrigatório")]
        public virtual Usuario Beneficiario { get; set; }

        [DataMember]
        [Required(ErrorMessage = "O campo de Valor da transferência é obrigatório")]
        [Range(0.00, 100000.00, ErrorMessage = "O valor da transferencia deverá ser no máximo de R$100.000,00.")]
        public decimal valor { get; set; }

        [DataMember]
        [StringLength(maximumLength: 4, ErrorMessage = "O campo de Tipo deve ter no máximo 4 caracteres.")]
        public string tipo { get; set; }

        [DataMember]
        [StringLength(maximumLength: 12, ErrorMessage = "O campo de Status deve ter no máximo 12 caracteres.")]
        public string status { get; set; }

    }
}