using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TodoApp.Models
{
    public class Todo
    {
        [Key]
        [Required]
        public int TodoId { get; set; }
        
        public string Title { get; set; }
        public bool IsDone { get; set; } = false;
        public DateTime? StartDate { get; set; }
        public DateTime? FinshDate { get; set; }

        [ForeignKey("Catergory")]
        public Catergory Catergories { get; set; }
      
    }
}
