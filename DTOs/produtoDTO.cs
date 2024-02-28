using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api_produto.DTOs
{
    public class produtoDTO
    {
        public string? NomeProduto {get;set;}

        public string? Categoria {get;set;}

        public string? Descricao {get;set;}

        public DateTime DataDeValidade{get;set;}

        public int Preco{get;set;}


    }
}