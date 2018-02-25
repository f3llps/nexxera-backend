﻿using AutoMapper;
using BancoNix.TransferenciaAPI.Dominio;
using System;
namespace BancoNix.TransferenciaAPI.API.AutoMapper
{
    public class AutoMapperManager
    {
        //Padrão Singleton
        private static readonly Lazy<AutoMapperManager> _instance = new Lazy<AutoMapperManager>(() => { return new AutoMapperManager(); });

        public static AutoMapperManager Instance
        {
            get
            {
                return _instance.Value;
            }
        }
        private MapperConfiguration _config;
        public IMapper Mapper
        {
            get { return _config.CreateMapper(); }
        }

        private AutoMapperManager()
        {
            _config = new MapperConfiguration((cfg) => { cfg.CreateMap<Transferencia, TransferenciaDTO>(); cfg.CreateMap<TransferenciaDTO, Transferencia>(); });
        }
    }
}
