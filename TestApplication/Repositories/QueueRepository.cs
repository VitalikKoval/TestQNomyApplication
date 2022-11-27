using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestApplication.Models;

namespace TestApplication.Repositories
{
    public class QueueRepository : IQueueRepository
    {
        private readonly TestDbContext _dbContext;
        public QueueRepository(TestDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<int> AddItemToQueue(QueueEntity queue)
        {
            List<SqlParameter> parms = new List<SqlParameter>
            {
                new SqlParameter { ParameterName = "@FullName", Value = queue.FullName },
                new SqlParameter { ParameterName = "@Number", Value = queue.Number },
                new SqlParameter { ParameterName = "@CheckInDate", Value = queue.CheckInDate },
                new SqlParameter { ParameterName = "@Status", Value = 0 }
            };

            var sp = "exec [dbo].[AddToQueue] @FullName, @Number, @CheckInDate, @Status";
            _dbContext.Users.FromSqlRaw<QueueEntity>(sp, parms.ToArray());
            return await _dbContext.SaveChangesAsync();
        }

        public async Task<List<QueueEntity>> GetUsers()
        {
            return await _dbContext.Users.ToListAsync();
        }
    }
}
