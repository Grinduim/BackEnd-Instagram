namespace Model;

public class Like{
    int ID {get;set;}
    DateTime Date {get;set;}
    User User {get;set;}
    Post? Post{get;set;}
    Comment? Comment {get;set;}
}