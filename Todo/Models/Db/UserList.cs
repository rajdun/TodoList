namespace Todo.Models.Db;

public class UserList
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public int ListId { get; set; }
    public bool IsOwner { get; set; }
    
    public virtual User User { get; set; }
    public virtual TaskListHeader TaskList { get; set; }
}