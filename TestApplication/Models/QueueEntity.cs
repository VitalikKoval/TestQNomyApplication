using System;
using System.ComponentModel.DataAnnotations;

namespace TestApplication.Models
{
    public class QueueEntity
    {
        [Key]
        public int Id { get; set; }
        public int Number { get; set; }
        public string FullName { get; set; }
        public DateTime CheckInDate { get; set; }
        public int Status { get; set; }
    }
}
