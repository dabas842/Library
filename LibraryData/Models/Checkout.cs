using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LibraryData.Models
{
    public partial class Checkout
    {
        public int Id { get; set; }
        public DateTime Since { get; set; }
        public DateTime Until { get; set; }

        [Required]
        public LibraryAsset LibraryAsset { get; set; }
        public LibraryCard LibraryCard { get; set; }
    }
}
