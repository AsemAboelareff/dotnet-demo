using QCTestProject.Models;

namespace QCTestProject.Services
{
    public class CacheItem
    {
        public Book Book { get; set; }
        public Author Author { get; set; }
        public Category Category { get; set; }
        public Language Language { get; set; }
        public Publisher Publisher { get; set; }
    }
}
