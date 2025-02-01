using System;
using System.ComponentModel.DataAnnotations;

namespace EventManagementSystem.Models
{
    public class Event
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        public string Location { get; set; }

        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        [StringLength(500)]
        public string Description { get; set; }
        
        
        public string UserId { get; set; }
        public virtual IdentityUser User { get; set; }
    }
}
