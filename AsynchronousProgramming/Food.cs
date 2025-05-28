namespace AsynchronousProgramming;

public class Food
{
    private readonly TimeSpan _cookTime;
    public string Name { get; }

    protected Food(TimeSpan cookTime)
    {
        _cookTime = cookTime;
        Name = GetType().Name;
    }

    public async Task Cook()
    {
        Console.WriteLine($"Cooking {Name}");
        await Task.Delay(_cookTime);
        Console.WriteLine($"{Name} completed");
    }
}
public class Turkey() : Food(TimeSpan.FromSeconds(5));
public class MashedPotato() : Food(TimeSpan.FromSeconds(2));
public class Gravy() : Food(TimeSpan.FromSeconds(1));
public class Stuffing() : Food(TimeSpan.FromSeconds(2));