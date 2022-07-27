namespace Model;
public class Post {
    int ID {get;set;}
    string Data {get;set;}
    string Description {get;set;}
    DateTime DatePost {get;set;}
    public List<Like> Likes {get;set;}
}