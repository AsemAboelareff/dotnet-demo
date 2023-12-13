using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace QCTestProject.Models
{
    public class Publisher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [JsonIgnore]
        public List<Book> Books { get; set; }
        public Publisher()
        {
            Books = new List<Book>();
        }
    }
}
