namespace Model;

public class Post{

    public int ID{ get; set; }
    public User User{ get; set; }
    public Likes Likes{ get; set; }
    public List<string> Data { get; set; }
    public string Description{ get; set; }
    public DateTime DatePost{ get; set; }
    
}