namespace Model;
public class Comments{
    public int ID{ get; set; }
    public User User{ get; set; }
    public string Text{ get; set; }
    public Likes Likes{ get; set; }
    public Post Post{ get; set; }
}