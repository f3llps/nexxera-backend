namespace BancoNix.TransferenciaAPI.Dominio
{
    public class Transferencia
    {
        public int id { get; set; }
        public string  id_transferencia { get; set; }
        public int usuario_id { get; set; }
        public virtual  Usuario Beneficiario { get; set; }
        public virtual Usuario Pagador { get; set; }
        public decimal valor { get; set; }
        public string tipo { get; set; }
        public string status { get; set; }
    }
}
