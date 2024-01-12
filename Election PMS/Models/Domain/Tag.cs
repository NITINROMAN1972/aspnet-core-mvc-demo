namespace Election_PMS.Models.Domain
{
    public class Tag
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }

        // for one to many mapping
        public ICollection<BlogPost> BlogPosts { get; set; }
    }
}
