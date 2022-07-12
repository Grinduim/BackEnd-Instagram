namespace Model;

public class Post{

    private int ID{ get; set; }
    private User User{ get; set; }
    private Likes Likes{ get; set; }
    private List<string> Data { get; set; }
    private string Description{ get; set; }
    private DateTime DatePost{ get; set; }
    
}