namespace Model;
public class User
{
    public int ID { get; set; }
    public string UserName { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string Phone { get; set; }
    public Address Address { get; set; }


    public int Save(){
        // using(var context = new Context()){
        //     context.Users.Add(this);
        //     context.SaveChanges();
        //     return this.ID;
        // }
        return 1;
    }
}
