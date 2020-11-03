using Dapper;
using GrahamUniversity.Application.Interfaces;
using GrahamUniversity.Core.Entities;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrahamUniversity.Infrastructure.Repository
{
    public class RatingsRepository : IRatingsRepository
    {
        private readonly IConfiguration configuration;
        public RatingsRepository(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        public async Task<int> AddAsync(Ratings entity)
        {
            var sql = "SP_AddRatings";
            using (var connection = new SqlConnection(configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var result = await connection.ExecuteAsync(sql, new { Id = entity.Id, Value = entity.Rating }, commandType: System.Data.CommandType.StoredProcedure);
                return result;
            }
        }

        public Task<IReadOnlyList<Ratings>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Ratings> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IReadOnlyList<Ratings>> GetRatingsByStudentId(int id)
        {
            var sql = "SP_GetRatings";
            using (var connection = new SqlConnection(configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var result = await connection.QueryAsync<Ratings>(sql, new { Id = id }, commandType: System.Data.CommandType.StoredProcedure);
                return result.ToList();
            }
        }

        public Task<int> UpdateAsync(Ratings entity)
        {
            throw new NotImplementedException();
        }
    }
}
