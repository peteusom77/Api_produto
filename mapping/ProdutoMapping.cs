using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api_produto.DTOs;
using Api_produto.Model;
using AutoMapper;

namespace Api_produto.mapping
{
    public class ProdutoMapping:Profile
    {
        public ProdutoMapping()
        {
            CreateMap<Produto,produtoDTO>().ReverseMap();
        }
    }
}