using System.ComponentModel.DataAnnotations;

namespace Todo.Models.Db;

public class User
{
    public int Id { get; set; }
    [StringLength(32)] 
    public string Email { get; set; }
    [StringLength(256)] 
    public string PasswordHash { get; set; }
    [StringLength(24)] 
    public string PasswordSalt { get; set; }

    public bool IsSuperuser { get; set; }
    public bool IsActive { get; set; }
    public DateTime DateCreated { get; set; }
    public DateTime LastVisited { get; set; }
    
    public virtual ICollection<TaskListHeader> TaskLists { get; set; }
}