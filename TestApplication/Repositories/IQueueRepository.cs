using System.Collections.Generic;
using System.Threading.Tasks;
using TestApplication.Models;

namespace TestApplication.Repositories
{
    public interface IQueueRepository
    {
        Task<int> AddItemToQueue(QueueEntity queue);
        Task<List<QueueEntity>> GetUsers();
    }
}
