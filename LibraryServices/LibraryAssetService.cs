using System.Collections.Generic;
using System.Linq;
using LibraryData;
using LibraryData.Models;
using Microsoft.EntityFrameworkCore;

namespace LibraryServices
{
    public class LibraryAssetService : ILibraryAsset
    {
        private readonly LibraryContext _context;

        public LibraryAssetService(LibraryContext contex)
        {
            _context = contex;
        }

        public IEnumerable<LibraryAsset> GetAll()
        {
            return _context.LibraryAssets
                .Include(asset => asset.Status)
                .Include(asset => asset.Location);
        }

        public LibraryAsset GetById(int id)
        {
            return GetAll()
                .FirstOrDefault(asset => asset.Id == id);
        }

        public void Add(LibraryAsset newAsset)
        {
            _context.LibraryAssets.Add(newAsset);
            _context.SaveChanges();
        }

        public string GetAuthorOrDirector(int id)
        {
            var isBook = _context.LibraryAssets.OfType<Book>().Any(a => a.Id == id);
            var isVideo = _context.LibraryAssets.OfType<Video>().Any(a => a.Id == id);

            return isBook
                ? _context.Books.FirstOrDefault(x => x.Id == id)?.Author
                : _context.Videos.FirstOrDefault(x => x.Id == id)?.Director
                  ?? "UNKOWN";
        }

        public string GetDeweyIndex(int id)
        {
            return _context.Books.Any(book => book.Id == id)
                ? _context.Books.FirstOrDefault(book => book.Id == id)?.DeweyIndex
                : string.Empty;
        }

        public string GetType(int id)
        {
            var book = _context.LibraryAssets.OfType<Book>()
                .Where(x => x.Id == id);

            return book.Any() ? "Book" : "Video";
        }

        public string GetTitle(int id)
        {
            return _context.LibraryAssets.FirstOrDefault(a => a.Id == id)?.Title;
        }

        public string GetIsbn(int id)
        {
            return _context.Books.Any(book => book.Id == id)
                ? _context.Books.FirstOrDefault(book => book.Id == id)?.ISBN
                : string.Empty;
        }

        public LibraryBranch GetCurrentLocation(int id)
        {
            return GetById(id).Location;
        }
    }
}