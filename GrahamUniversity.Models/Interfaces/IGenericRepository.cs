﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GrahamUniversity.Application.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> GetByIdAsync(int id);
        Task<IReadOnlyList<T>> GetAllAsync();
    }
}
