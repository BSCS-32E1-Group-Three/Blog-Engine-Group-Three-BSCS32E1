namespace Blog_Engine.Models
{
	public class Blog
	{
        public int ID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
		public string Author { get; set; }
		public DateOnly Date { get; set; }
        
    }
}
