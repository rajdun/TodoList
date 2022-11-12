using System.ComponentModel.DataAnnotations;

namespace Todo.Models.Db;

public class TaskListHeader
{
    public int Id { get; set; }
    [StringLength(32)]
    public string Name { get; set; }
    [StringLength(32)]
    public string Slug { get; set; }
    [StringLength(64)]
    public string Description { get; set; }
    public bool IsActive { get; set; }
    
    public virtual ICollection<SingleTask> TaskList { get; set; }
    public virtual ICollection<User> Users { get; set; }
}