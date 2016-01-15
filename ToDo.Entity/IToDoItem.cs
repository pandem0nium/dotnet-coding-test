using System;
namespace ToDo.Entity
{
    public interface IToDoItem
    {
        bool Complete { get; set; }
        string Description { get; set; }
        string Id { get; set; }
        string Title { get; set; }
        string Parent_task_id { get; set; }
    }
}
