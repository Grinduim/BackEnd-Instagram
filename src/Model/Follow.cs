namespace Model;

public class Follow {
    int ID {get;set;}
    public User User { get; set; }  
    public User Following { get; set; }

    public Post? Post { get; set; } 
    public Comment? Comment { get; set; }
    public ResponseComment? ResponseComment {get; set; }
}