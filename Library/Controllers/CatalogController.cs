using Library.Models.Catalog;
using LibraryData;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Library.Controllers
{
    public class CatalogController : Controller
    {
        private readonly ILibraryAsset _asset;

        public CatalogController(ILibraryAsset asset) => _asset = asset;

        public IActionResult Details(int id)
        {
            var asset = _asset.GetById(id);

            var model = new AssetDetailsModel()
            {
                AssetId = asset.Id,
                Title = asset.Title,
                Year = asset.Year,
                Coast = asset.Cost,
                Status = asset.Status.Name,
                ImageUrl = asset.ImageUrl,
                AuthorOrDirector = _asset.GetAuthorOrDirector(id),
                CurrentLocation = _asset.GetCurrentLocation(id).Name,
                DeweyCallNumber = _asset.GetDeweyIndex(id),
                ISBN = _asset.GetIsbn(id),
            };

            return View(model);
        }

        public IActionResult Index()
        {
            var assetModels = _asset.GetAll();

            var listingResult = assetModels
                .Select(result => new AssetIndexListingModel
                {
                    Id = result.Id,
                    ImageUrl = result.ImageUrl,
                    Title = result.Title,
                    NumberOfCopies = result.NumberOfCopies,
                    AuthorOrDirector = _asset.GetAuthorOrDirector(result.Id),
                    DeweyCallNumber = _asset.GetDeweyIndex(result.Id),
                    Type = _asset.GetType(result.Id)
                });

            var model = new AssetIndexModel
            {
                Assets = listingResult
            };

            return View(model);
        }

        public IActionResult Checkout(int id)
        {

        }
    }
}