using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api_produto.Data;
using Api_produto.DTOs;
using Api_produto.Model;
using Api_produto.Repositorio.InterFace;
using Microsoft.EntityFrameworkCore;

namespace Api_produto.Repositorio
{
    public class ProdutoRepositorio : IProdutoRepositorio
    {
        private readonly AppDbcontext _Dbcontext;
        public ProdutoRepositorio(AppDbcontext appContext)
        {
            _Dbcontext = appContext;
        }

        public async Task<produtoDTO> AdicionarProduto(produtoDTO Newproduto)
        {
            var NovoProduto = new Produto
            {
                NomeProduto =Newproduto.NomeProduto,
                Categoria = Newproduto.Categoria,
                Descricao =Newproduto.Categoria,
                DataDeValidade =Newproduto.DataDeValidade,
                Preco =Newproduto.Preco
            };
            await _Dbcontext.produtos.AddAsync(NovoProduto);
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