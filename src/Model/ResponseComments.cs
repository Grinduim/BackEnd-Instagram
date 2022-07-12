namespace Model;

public class ResponseComments 
{
    public int ID { get; set; }
    public User User { get; set; }
    public string Text { get; set; }
    public Likes Likes { get; set; }
    public Comments Comment { get; set; }
}