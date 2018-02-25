using BancoNix.Comum.Repositorios.Entity;
using BancoNix.TransferenciaAPI.AcessaDados.Entity.Context;
using BancoNix.TransferenciaAPI.Dominio;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace BancoNix.TransferenciaAPI.Repositorios.Entity
{
    public class RepositorioTransferencias : RepositorioBancoNix<Transferencia, int>
    {
        public RepositorioTransferencias(BancoNixDbContext context): base(context)
        {

        }

         public override List<Transferencia> Selecionar(Expression<Func<Transferencia, bool>> where = null)
        {
            DbSet<Transferencia> dbSet = _context.Set<Transferencia>();
            if (where == null)
            {
                return dbSet.Include("Pagador").Include("Beneficiario").ToList();
            }
            else
            {
                return dbSet.Where(where).ToList();
            }
        }


        public override Transferencia SelecionarPorId(int id)
        {
            DbSet<Transferencia> dbSet = _context.Set<Transferencia>();
            return dbSet.Include("Pagador").Include("Beneficiario").Where(x => x.id == id).First();
        }
    }
}
