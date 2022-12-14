namespace myblog.Entity
{
    public class Post
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Picture { get; set; }
        public bool Aktive { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
