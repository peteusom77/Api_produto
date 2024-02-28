using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api_produto.DTOs;
using Api_produto.Model;
using Api_produto.Repositorio;
using Api_produto.Repositorio.InterFace;
using Microsoft.AspNetCore.Mvc;

namespace Api_produto.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProdutoControllers:ControllerBase
    {
        public readonly IProdutoRepositorio produtoRe;
        public ProdutoControllers(IProdutoRepositorio pro_)
        {
            produtoRe =pro_;
        }
        [HttpPost]
        [Route("Adicionar Produto")]
        public async Task<ActionResult<produtoDTO>> AdicionarProduto([FromBody] produtoDTO produto)
        {
            produtoDTO voi = await produtoRe.AdicionarProduto(produto);
            return produto;
        }
    }
}