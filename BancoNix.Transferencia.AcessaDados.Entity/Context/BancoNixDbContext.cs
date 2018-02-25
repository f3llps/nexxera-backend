using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BancoNix.TransferenciaAPI.Dominio;

namespace BancoNix.TransferenciaAPI.AcessaDados.Entity.Context
{
    public class BancoNixDbContext : DbContext
    {
        public DbSet<Transferencia> Tranferencias { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        public BancoNixDbContext()
        {
            Configuration.ProxyCreationEnabled = false;
           // Configuration.LazyLoadingEnabled = false;
        }

    }

}
