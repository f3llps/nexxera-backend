using BancoNix.Comum.Repositorios.Interfaces;
using BancoNix.TransferenciaAPI.AcessaDados.Entity.Context;
using BancoNix.TransferenciaAPI.API;
using BancoNix.TransferenciaAPI.API.AutoMapper;
using BancoNix.TransferenciaAPI.Dominio;
using BancoNix.TransferenciaAPI.Repositorios.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;
using System.Web.Http.Results;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class TransferenciaController : ApiController
    {
        private IRepositorioBancoNix<Transferencia, int> _repositorioTransferencia
            = new RepositorioTransferencias(new BancoNixDbContext());

        public IHttpActionResult Get()
        {
            List<Transferencia> lstTransferencia = _repositorioTransferencia.Selecionar();
            List<TransferenciaDTO> lstUsuarioDTO = AutoMapperManager.Instance.Mapper.Map<List<Transferencia>, List<TransferenciaDTO>>(lstTransferencia);
            return Ok(lstUsuarioDTO);
        }

        public IHttpActionResult Get(int? id)
        {
            if (!id.HasValue)
            {
                return BadRequest();
            }

            Transferencia transferencia = _repositorioTransferencia.SelecionarPorId(id.Value);
            if (transferencia == null)
            {
                return NotFound();
            }

            TransferenciaDTO transferenciaDTO = AutoMapperManager.Instance.Mapper.Map<Transferencia, TransferenciaDTO>(transferencia);

            return Content(HttpStatusCode.Found, transferenciaDTO);
        }

        public IHttpActionResult Post([FromBody]TransferenciaDTO transferenciaDTO)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    Transferencia transferencia = AutoMapperManager.Instance.Mapper.Map<TransferenciaDTO, Transferencia>(transferenciaDTO);
                    _repositorioTransferencia.Inserir(transferencia);
                    return Created($"{Request.RequestUri}/{transferenciaDTO.id}", transferenciaDTO);
                }
                catch (Exception ex)
                {
                    return InternalServerError(ex);
                }

            }
            else
            {
                return BadRequest(ModelState);
            }
        }

        public IHttpActionResult Put(int? id, [FromBody]Transferencia transferencia)
        {
            try
            {
                if (!id.HasValue)
                {
                    return BadRequest();
                }
                transferencia.id = id.Value;
                _repositorioTransferencia.Atualizar(transferencia);
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
                _repositorioTransferencia.ExcluirPorId(id.Value);

                return Ok();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        public IHttpActionResult List(int skip, int take, string nome)
        {
            IEnumerable<Transferencia> lstTransferencias = _repositorioTransferencia.Selecionar().ToList();
            if (!String.IsNullOrEmpty(nome))
            {
                lstTransferencias = lstTransferencias.Where(x => x.Beneficiario.nome.Contains(nome) || x.Pagador.nome.Contains(nome));
            }

            var teste = lstTransferencias.Skip(skip * take).Take(take);
            IEnumerable<TransferenciaDTO> lstUsuarioDTO = AutoMapperManager.Instance.Mapper.Map<IEnumerable<Transferencia>, IEnumerable<TransferenciaDTO>>(teste);

            return Ok(lstUsuarioDTO);

        }
    }
}