using System.ComponentModel.DataAnnotations;

namespace  BancoNix.TransferenciaAPI.API
{
    public class UsuarioDTO
    {
        public int id { get; set; }
        [StringLength(maximumLength: 128, ErrorMessage = "O campo de Nome do Pagador deve ter no máximo 128 caracteres.")]
        public string nome { get; set; }
        public string cnpj { get; set; }
    }
}