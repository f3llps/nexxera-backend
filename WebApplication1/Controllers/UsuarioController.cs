using BancoNix.Comum.Repositorios.Interfaces;
using BancoNix.TransferenciaAPI.AcessaDados.Entity.Context;
using BancoNix.TransferenciaAPI.Dominio;
using BancoNix.TransferenciaAPI.Repositorios.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication1.Controllers
{
    public class UsuarioController : ApiController
    {
        private IRepositorioBancoNix<Usuario, int> _repositorioUsuario
            = new RepositorioUsuarios(new BancoNixDbContext());

        public IHttpActionResult Get()
        {
            return Ok(_repositorioUsuario.Selecionar());
        }

        public IHttpActionResult Get(int? id)
        {
            if (!id.HasValue)
            {
                return BadRequest();
            }
            Usuario usuario = _repositorioUsuario.SelecionarPorId(id.Value);
            if (usuario == null)
            {
                return NotFound();
            }
            return Content(HttpStatusCode.Found, usuario);
        }

        public IHttpActionResult Post([FromBody]Usuario usuario)
        {
            try
            {
                _repositorioUsuario.Inserir(usuario);
                return Created($"{Request.RequestUri}/{usuario.id}", usuario);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }

        }

        public IHttpActionResult Put(int? id, [FromBody]Usuario usuario)
        {
            try
            {
                if (!id.HasValue)
                {
                    return BadRequest();
                }
                usuario.id = id.Value;
                _repositorioUsuario.Atualizar(usuario);
                return Ok();
            }
            catch (Exception ex)
            {

                return InternalServerError(ex);
            }


        }
        public IHttpActionResult Delete(int? id)
        {
            try
            {
                if (!id.HasValue)
                {
                    return BadRequest();

                }
                _repositorioUsuario.ExcluirPorId(id.Value);
                return Ok();
            }
            catch (Exception ex)
            {

                return InternalServerError(ex);
            }
        }
    }
}
