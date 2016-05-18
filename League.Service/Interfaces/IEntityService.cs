﻿using League.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace League.Service 
{
    public interface IEntityService<T> : IService 
    {
        void Create(T entity);
        void Delete(T entity);
        void Update(T entity);

        IEnumerable<T> GetAll();
    }
}
