﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.TodoAppNTier.DataAccess.Contexts;
using Udemy.TodoAppNTier.DataAccess.Interfaces;
using Udemy.TodoAppNTier.DataAccess.Repositories;

namespace Udemy.TodoAppNTier.DataAccess.UnitOfWork
{
    public class Uow : IUow
    {
        private readonly ToDoContext _context;

        public Uow(ToDoContext context)
        {
            _context = context;
        }

        public IRepository<T> GetRepository<T>() where T : class, new()
        {
            return new Repository<T>(_context);
        }

        public Task SaveChanges()
        {
            return _context.SaveChangesAsync();
        }
    }
}