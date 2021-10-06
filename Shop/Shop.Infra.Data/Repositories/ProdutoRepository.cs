using Shop.Domain.Entities;
using Shop.Domain.Interfaces;
using Shop.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.Domain.Repositories
{
    public class ProdutoRepository : IProdutoRepository
    {
        public AppDbContext _context;

        public ProdutoRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Produto> GetProdutoss()
        {
            return _context.Produtos;
        }
    }
}
