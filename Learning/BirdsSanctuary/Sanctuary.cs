namespace ConsoleAppLearning1.Learning.Operator.Learning.Generic.Learning.BirdsSanctuary;

public class Sanctuary
{
    private List<Bird> birds = new();

    public void Add(Bird bird)
    {
        birds.Add(bird);
    }
    public void Remove(Bird bird)
    {
        birds.Remove(bird);
    }

    public bool FindExistWithId(int id)
    {
        if (birds.Exists((bird => bird.Id == id)))
        {
            return true;
        }
        return false;
    }

    public Bird FindBirdById(int id)
    {
        if (!FindExistWithId(id))
        {
            return null;
        }
        return birds.First(bird => bird.Id == id);
    }
    public void DisplayBirds()
    {
        foreach (var bird in birds)
        {
            Console.WriteLine(bird);
        }
    }
    
    
    
}