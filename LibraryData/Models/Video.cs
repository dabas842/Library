using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LibraryData.Models
{
    public partial class Video:LibraryAsset
    {
        [Required]
        public string Director { get; set; }
    }
}
