using Microsoft.Extensions.DependencyInjection;
using Shop.Application.Interfaces;
using Shop.Application.Services;
using Shop.Domain.Interfaces;
using Shop.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.Infrastructure.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            // Adicionando Application
            services.AddScoped<IProdutoService, ProdutoService>();

            // Add Domain
            services.AddScoped<IProdutoRepository, ProdutoRepository>();
        }
    }
}
