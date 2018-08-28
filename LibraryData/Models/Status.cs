using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LibraryData.Models
{
    public partial class Status
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
    }
}
