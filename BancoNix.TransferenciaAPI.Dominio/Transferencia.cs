namespace BancoNix.TransferenciaAPI.Dominio
{
    public class Transferencia
    {
        public int id { get; set; }
        public int usuario_id { get; set; }

        public string pagador_nome { get; set; }
        public string pagador_banco { get; set; }
        public string pagador_agencia { get; set; }
        public string pagador_conta { get; set; }

        public string beneficiario_nome { get; set; }
        public string beneficiario_banco { get; set; }
        public string beneficiario_agencia { get; set; }
        public string beneficiario_conta { get; set; }

        public decimal valor { get; set; }
        public string tipo { get; set; }
        public string status { get; set; }
    }
}
