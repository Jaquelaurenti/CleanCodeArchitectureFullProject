using Shop.Application.Interfaces;
using Shop.Application.ViewModels;
using Shop.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.Application.Services
{
    public class ProdutoService : IProdutoService
    {
        public IProdutoRepository _produtoRepository;

        public ProdutoService(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;

        }

        public ProdutoViewModel GetProdutos()
        {
            return new ProdutoViewModel()
            {
                Produtos = _produtoRepository.GetProdutoss()
            };
        }
    }
}
