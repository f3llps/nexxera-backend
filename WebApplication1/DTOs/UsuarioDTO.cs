using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace BancoNix.TransferenciaAPI.API
{    public class UsuarioDTO
    {

         [DataMember]
        [Required(ErrorMessage = "O campo Nome é obrigatório")]
        [StringLength(maximumLength: 128, ErrorMessage = "O campo de Nome deve ter no máximo 128 caracteres.")]
        public string nome { get; set; }

        [DataMember]
        [StringLength(maximumLength: 3, ErrorMessage = "O campo de Nome deve ter no máximo 3 caracteres.")]
        public string banco { get; set; }

        [DataMember]
        [Required(ErrorMessage = "O campo de Agência do é obrigatório")]
        [StringLength(maximumLength: 4, ErrorMessage = "O campo de Agência do Pagador deve ter no máximo 4 caracteres.")]
        public string agencia { get; set; }

        [DataMember]
        [Required(ErrorMessage = "O campo de Conta é obrigatório")]
        [StringLength(maximumLength: 6, ErrorMessage = "O campo de Conta do Pagador deve ter no máximo 6 caracteres.")]
        public string conta { get; set; }


    }
}