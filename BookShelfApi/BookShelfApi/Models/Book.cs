using System;
namespace BookShelfApi.Models
{
    public class Book
    {
        public long Id { get; set; }
        public string title { get; set; }
        public string author { get; set; }
        public string isbn { get; set; }
        public bool loaned { get; set; }
    }
}
