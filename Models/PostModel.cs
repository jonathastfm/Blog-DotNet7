namespace WebApplication1.Models;

public class PostModel
{
    public Guid ID { get; set; }
    public string Title { get; set; }
    public DateTime CreateAt { get; set; }
    public string Body { get; set; }
    public DateTime UpdateAt { get; set; }
    public Guid categoryID { get; set; }
}