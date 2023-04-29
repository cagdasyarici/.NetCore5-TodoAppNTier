using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.TodoAppNTier.Business.Interfaces;
using Udemy.TodoAppNTier.Business.Services;
using Udemy.TodoAppNTier.DataAccess.Contexts;
using Udemy.TodoAppNTier.DataAccess.UnitOfWork;

namespace Udemy.TodoAppNTier.Business.DependencyResolvers.Microsoft
{
    public static class DependencyExtension
    {
        public static void AddDependencies(this IServiceCollection services)
        {
            
            services.AddDbContext<ToDoContext>(opt =>
            {
                opt.UseSqlServer("Server=Chadowa;Database=ToDoAppDb;Trusted_Connection=True");
            });
            services.AddScoped<IUow,Uow>();
            services.AddScoped<IWorkService,WorkService>();
        }

    }
}
