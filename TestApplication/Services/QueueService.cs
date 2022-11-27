using AutoMapper;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestApplication.Dtos;
using TestApplication.Models;
using TestApplication.Repositories;

namespace TestApplication.Services
{
    public class QueueService : IQueueService
    {
        private readonly IQueueRepository _queueRepository;
        private readonly IMapper _mapper;

        public QueueService(IQueueRepository queueRepository, IMapper mapper)
        {
            _queueRepository = queueRepository;
            _mapper = mapper;
        }

        public async Task<int> AddItemToQueue(QueueDto dto)
        {
            var entity = _mapper.Map<QueueDto, QueueEntity>(dto);
            return await _queueRepository.AddItemToQueue(entity);
        }

        public async Task<List<QueueDto>> GetUsers()
        {
            return (await _queueRepository.GetUsers())
                .Select(x => new QueueDto() { Number = x.Number, FullName = x.FullName, CheckInDate = x.CheckInDate, Status = x.Status }).ToList();
        }
    }
}
