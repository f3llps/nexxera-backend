namespace BancoNix.TransferenciaAPI.Dominio
{
    public class Usuario
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string banco { get; set; }
        public string agencia { get; set; }
        public string conta { get; set; }
        public string cnpj { get; set; }

    }
}
