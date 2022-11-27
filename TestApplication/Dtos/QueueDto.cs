using System;
using TestApplication.Models;

namespace TestApplication.Dtos
{
    public class QueueDto
    {
        public int Number { get; set; }
        public string FullName { get; set; }
        public DateTime CheckInDate { get; set; }
        public int Status { get; set; }
    }
}
