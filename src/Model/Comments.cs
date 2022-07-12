namespace Model;
public class Comments{
    private int ID{ get; set; }
    private User User{ get; set; }
    private string Text{ get; set; }
    private Likes Likes{ get; set; }
    private Post Post{ get; set; }
}