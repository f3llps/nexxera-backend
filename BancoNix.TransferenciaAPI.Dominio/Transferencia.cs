using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoNix.TransferenciaAPI.Dominio
{
   public class Transferencia
    {
        public int id { get; set; }
        public int usuario_id { get; set; }
        public string  pagador_nome { get; set; }
        public string pagador_banco { get; set; }
        public string pagador_agencia { get; set; }
        public string pagador_conta { get; set; }
        public string beneficiario_nome { get; set; }
        public string beneficiario_agencia { get; set; }
        public string beneficiario_conta { get; set; }
        public string valor { get; set; }
        public string status { get; set; }
    }
}
