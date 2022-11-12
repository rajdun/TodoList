using System.ComponentModel.DataAnnotations;

namespace Todo.Models.Db;

public class SingleTask
{
    public int Id { get; set; }
    [StringLength(32)]
    public string Name { get; set; }
    public bool IsDone { get; set; }
    public int TaskHeaderId { get; set; }
    
    public virtual TaskListHeader TaskListHeader { get; set; }
}