namespace CountItMVC.Domain.Model
{
    public class CategoryTag
    {
        public int CategoryId { get; set; }
        public int TagId { get; set; }
        public Tag Tag { get; set; }
        public Category Category { get; set; }
    }
}