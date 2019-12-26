namespace restApi.Models
{
    public class Book
    {
        public long Id { get; set; }
        public string Title { get; set; }

        public Book(long id, string title)
        {
            Id = id;
            Title = title;
        }
    }
}