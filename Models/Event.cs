using System;
using System.ComponentModel.DataAnnotations;

namespace EventManagementSystem
{
    public class Event
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Title { get; set; }

        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        public string Description { get; set; }

        public string UserId { get; set; }
    }
}
