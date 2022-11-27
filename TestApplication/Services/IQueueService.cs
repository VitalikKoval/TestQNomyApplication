using System.Collections.Generic;
using System.Threading.Tasks;
using TestApplication.Dtos;
using TestApplication.Models;

namespace TestApplication.Services
{
    public interface IQueueService
    {
        Task<int> AddItemToQueue(QueueDto dto);
        Task<List<QueueDto>> GetUsers();
    }
}
