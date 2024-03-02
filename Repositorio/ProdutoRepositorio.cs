using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api_produto.Data;
using Api_produto.DTOs;
using Api_produto.Model;
using Api_produto.Repositorio.InterFace;
using AutoMapper;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;

namespace Api_produto.Repositorio
{
    public class ProdutoRepositorio : IProdutoRepositorio
    {
        private readonly AppDbcontext _Dbcontext;
        private readonly IMapper _mapper;
        public ProdutoRepositorio(AppDbcontext appContext, IMapper mapper)
        {
            _Dbcontext = appContext;
            _mapper = mapper;
        }

        public async Task<produtoDTO> AdicionarProduto(produtoDTO Newproduto)
        {
            var produtoDTOs =  _mapper.Map<Produto>(Newproduto);
            await _Dbcontext.produtos.AddAsync(produtoDTOs);
            await _Dbcontext.SaveChangesAsync();
            return Newproduto;
        }

        public Task<Produto> AtualizarProduto(Produto Newproduto, int id)
        {
            throw new NotImplementedException();
        }

        public Task<Produto> BocasrPorCatedotia(string Categoria)
        {
            throw new NotImplementedException();
        }

        public Task<Produto> BocasrPorpreco(string Preco)
        {
            throw new NotImplementedException();
        }

        public Task<Produto> BoscarPordataDeExpiração(DateTime dataDeExpiração)
        {
            throw new NotImplementedException();
        }

        public Task<List<Produto>> catalogo()
        {
            throw new NotImplementedException();
        }
    }
}