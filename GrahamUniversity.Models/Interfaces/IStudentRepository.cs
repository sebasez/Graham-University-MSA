using GrahamUniversity.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GrahamUniversity.Application.Interfaces
{
    public interface IStudentRepository : IGenericRepository<Student>
    {
        Task<int> AddAsync(Student entity);
        Task<int> UpdateAsync(Student entity);
    }
}
