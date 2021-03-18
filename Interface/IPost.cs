namespace ProftaakDemo.Models
{
    public interface IPost
    {
        string Author { get; set; }
        string Description { get; set; }
        int Id { get; set; }
        string Tag { get; set; }
        string Title { get; set; }
    }
}