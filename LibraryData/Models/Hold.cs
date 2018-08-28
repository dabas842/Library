using System;
using System.Collections.Generic;

namespace LibraryData.Models
{
    public partial class Hold
    {
        public int Id { get; set; }
        public DateTime HoldPlaced { get; set; }

        public LibraryAsset LibraryAsset { get; set; }
        public LibraryCard LibraryCard { get; set; }
    }
}
