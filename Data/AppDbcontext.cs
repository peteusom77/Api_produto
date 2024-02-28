using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api_produto.Model;
using Microsoft.EntityFrameworkCore;

namespace Api_produto.Data
{
    public class AppDbcontext:DbContext
    {
        public DbSet<Produto> produtos{get;set;}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        =>optionsBuilder.UseNpgsql(connectionString:"Host=localhost;Username=postgres;password=;database=Produto");
    }
}