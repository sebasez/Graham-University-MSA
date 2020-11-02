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
        public Task<int> AddAsync(Ratings entity)
        {
            throw new NotImplementedException();
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
            var sql = "SELECT * FROM RATINGS R WHERE R.STUDENTID = @Id;";
            using (var connection = new SqlConnection(configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var result = await connection.QueryAsync<Ratings>(sql, new { Id = id });
                return result.ToList();
            }
        }

        public Task<int> UpdateAsync(Ratings entity)
        {
            throw new NotImplementedException();
        }
    }
}
