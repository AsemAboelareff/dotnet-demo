using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace QCTestProject.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [JsonIgnore]
        public List<Book> Books { get; set; }
        public Category()
        {
            Books = new List<Book>();
        }
    }
}
