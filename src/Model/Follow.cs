namespace Model;

public class Follow {
    public int ID { get; set; }
    public User Follower { get; set; }
    public User User { get; set; }

}