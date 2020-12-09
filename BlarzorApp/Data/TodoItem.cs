using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Data
{
    public class TodoItem
    {
        public int Id { get; set; }
        [Required]
        [StringLength(10, ErrorMessage ="Name is too long.")]
        public string Title { get; set; }
        public bool IsDone { get; set; }
    }
}
