using System;
using System.Collections.Generic;
using LibraryData.Models;

namespace Library.Models.Catalog
{
    public class AssetDetailsModel
    {
        public int AssetId { get; set; }
        public string Title { get; set; }
        public string AuthorOrDirector { get; set; }
        public string Type { get; set; }
        public int Year { get; set; }
        public string ISBN { get; set; }
        public string DeweyCallNumber { get; set; }
        public string Status { get; set; }
        public decimal Coast { get; set; }
        public string CurrentLocation { get; set; }
        public string ImageUrl { get; set; }
        public string PatronName { get; set; }
        public Checkout LatestCheckout { get; set; }
        public IEnumerable<CheckoutHistory> CheckoutHistory { get; set; }
        public IEnumerable<AssetHolModel> CurrentHolds { get; set; }
    }

    public class AssetHolModel
    {
        public string PatronName { get; set; }
        public string HoldPlaced { get; set; }
    }
}