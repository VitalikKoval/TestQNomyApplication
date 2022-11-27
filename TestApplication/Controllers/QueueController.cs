using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestApplication.Dtos;
using TestApplication.Services;

namespace TestApplication.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class QueueController : ControllerBase
    {
        private readonly IQueueService _queueService;
        private readonly ILogger<QueueController> _logger;

        public QueueController(ILogger<QueueController> logger, IQueueService queueService)
        {
            _logger = logger;
            _queueService = queueService;
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync([FromBody] QueueDto queueDto)
        {
            return Ok(await _queueService.AddItemToQueue(queueDto));
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            return Ok(_queueService.GetUsers());
        }
    }
}
