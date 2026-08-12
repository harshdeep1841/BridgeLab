namespace ConsoleAppLearning1.Learning.Operator.Learning.Collections.AssignementDataStructures;

public class Task
{
    public int TaskId { get; set; }

    public string TaskName { get; set; }

    public int Priority { get; set; }

    public DateTime DueDate { get; set; }

    public Task(int taskId, string taskName, int priority, DateTime dueDate)
    {
        TaskId = taskId;
        TaskName = taskName;
        Priority = priority;
        DueDate = dueDate;
    }

    public override string ToString()
    {
        return $"ID : {TaskId}, Name : {TaskName}, Priority : {Priority}, Due : {DueDate.ToShortDateString()}";
    }
}

public class TaskNode
{
    public Task Data { get; set; }

    public TaskNode Next { get; set; }

    public TaskNode(Task task)
    {
        Data = task;
    }
}