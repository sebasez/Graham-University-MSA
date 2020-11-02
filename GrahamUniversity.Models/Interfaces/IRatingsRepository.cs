using GrahamUniversity.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GrahamUniversity.Application.Interfaces
{
    public interface IRatingsRepository : IGenericRepository<Ratings>
    {
        Task<int> AddAsync(Ratings entity);
        Task<int> UpdateAsync(Ratings entity);
        Task<IReadOnlyList<Ratings>> GetRatingsByStudentId(int id);
    }
}
