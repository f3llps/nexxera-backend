using BancoNix.Comum.Repositorios.Entity;
using BancoNix.TransferenciaAPI.AcessaDados.Entity.Context;
using BancoNix.TransferenciaAPI.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoNix.TransferenciaAPI.Repositorios.Entity
{
    public class RepositorioUsuarios : RepositorioBancoNix<Usuario, int>
    {
        public RepositorioUsuarios(BancoNixDbContext context): base(context)
        {

        }
    }
}
