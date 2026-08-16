namespace ConsoleAppLearning1.Learning.Operator.Learning.Test.TaskSchedular;

public class Task
{
    public long Id { get; set; }
    public string Name { get; set; }
    public string Priority { get; set; }
    public DateTime DueDate { get; set; }

    public Task(long id, string name, string priority, DateTime dueDate)
    {
        Id = id;
        Name = name;
        Priority = priority;
        DueDate = dueDate;
    }
    
    
}

public class TaskNode
{
    public Task Task { get; set; }
    public TaskNode NextTask { get; set; }

    public TaskNode(Task task , TaskNode nextTask)
    {
        Task = task;
        NextTask = nextTask;
    }
}