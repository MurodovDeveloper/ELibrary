﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELibrary.Infrastucture.Application.Interfaces
{

    public interface IRepository<T>
    {
      public  Task<IEnumerable<T>> GetAllAsync();
       public Task<T> GetByIdAsync(int id);
      public  Task AddAsync(T obj);
       public Task<bool> UpdateAsync(T entity);
      public  Task DeleteAsync(int id);
       public Task AddRangeAsync(List<T> entities);
    }

}

