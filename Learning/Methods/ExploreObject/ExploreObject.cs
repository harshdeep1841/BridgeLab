namespace ConsoleAppLearning1.Learning.Operator.Learning.Methods.ExploreObject;

public class ExploreObject
{
    private int id { get; set; }
    private string name { get; set; }

   public ExploreObject(int id, string name)
    {
        this.id = id;
        this.name = name;
    }

    public override bool Equals(object? obj)
    {
        if(obj == null) return false;
        ExploreObject newObj = obj as ExploreObject;
        return newObj.id == this.id && newObj.name == this.name;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(id, name);
    }
}