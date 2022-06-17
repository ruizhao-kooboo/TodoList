namespace EFcore_First.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime PublieshedOn { get; set; }

        public string Publisher { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
    }
}
