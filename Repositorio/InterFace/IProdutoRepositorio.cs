using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api_produto.DTOs;
using Api_produto.Model;
using Microsoft.VisualBasic;

namespace Api_produto.Repositorio.InterFace
{
    public interface IProdutoRepositorio
    {
        Task<List<Produto>>catalogo();
        Task<produtoDTO> AdicionarProduto(produtoDTO Newproduto);
        Task<Produto> AtualizarProduto(Produto Newproduto,int id);
        Task<Produto> BocasrPorCatedotia(string Categoria);
        Task<Produto> BocasrPorpreco(string Preco);
        Task<Produto>BoscarPordataDeExpiração(DateTime dataDeExpiração);

    }
}