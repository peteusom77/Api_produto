using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace Api_produto.Model
{
    [Table("produto")]
    public class Produto
    {
        [Key]
        [Column("id")]
        public int Id {get;set;}

        [Column("nomeproduto")]
        public string? NomeProduto {get;set;}

        [Column("categoria")]
        public string? Categoria {get;set;}

        [Column("descricao")]
        public string? Descricao {get;set;}

        [Column("datadevalidade")]
        public DateTime DataDeValidade{get;set;}

        [Column("preco")]
        public int Preco{get;set;}

        
        
    }
}