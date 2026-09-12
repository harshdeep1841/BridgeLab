namespace ConsoleAppLearning1.Learning.Operator.Learning.Generic.Learning.BirdsSanctuary;

public enum Gender
{
    male,
    female
}
public abstract class Bird
{
    public int  Id { get; set; }
    public string Weight_Catagory { get; set; }
    
    public Gender Gender { get; set; }
    public Bird()
    {
        Id = -1;
        Weight_Catagory = "";
    }
    public Bird(int id  ,  string weightCatagory , Gender gender)
    {
        Id = id;
        Weight_Catagory = weightCatagory;
        Gender = gender;
    }


    public override string ToString()
    {
        return $"{Id} {Weight_Catagory}";
    }

    public override bool Equals(object? obj)
    {
        Bird bird = obj as  Bird;
        return bird.Id == Id;
    }

    public override int GetHashCode()
    {
        return Id.GetHashCode();
    }
}