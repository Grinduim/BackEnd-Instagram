namespace Model;

public class Comment {
    int ID {get;set;}
    public string Text { get; set; }
    public User User { get; set; } 
    public Post Post { get; set; }  
    public List<Like> Likes {get;set;}
}