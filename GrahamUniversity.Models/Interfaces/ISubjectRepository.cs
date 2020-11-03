using GrahamUniversity.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GrahamUniversity.Application.Interfaces
{
    public interface ISubjectRepository : IGenericRepository<Subject>
    {
        Task<int> AddAsync(Subject entity, int studentId);
    }
}
