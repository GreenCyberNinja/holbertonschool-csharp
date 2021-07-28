using System;

abstract class Base
{
    public string name { get; set; }

    public override string ToString()
    {
        return ($"{name} is a {GetType()}");
    }
}
class  Door : Base, IInteracticve
{
    public void Interact()
    {
        Console.WriteLine($"You try to open the {name}. its locked");
    }
    public Door(string Name = "Door")
    {
        this.name = Name;
    }
}
class Decoration : Base, IInteracticve, IBreakable
{
    public int durability {get; set; }
    public bool isQuestItem;
    public Decoration (string name = "Decoration", int durability = 1, bool isQuestItem = false)
    {
        if (durability < 0)
        {
            throw new Exception("Durability must be greater than 0");
        }
        this.name = name;
        this.durability = durability;
        this .isQuestItem = isQuestItem;

    }
    public void Interact()
    {
        if (durability <= 0)
            Console.WriteLine($"The {name} has been broken.");
        if (isQuestItem)
                Console.WriteLine($"You look at the {name}. There's a key inside.");
        if (!isQuestItem && durability > 0)
            Console.WriteLine($"You look at the {name}. Not much to see here.");

    }

    public void Break()
    {
        durability--;
        if (durability > 0)
            Console.WriteLine($"You hit the {name}. It cracks.");
        if (durability == 0)
            Console.WriteLine($"You smash the {name}. What a mess.");
        if (durability < 0)
            Console.WriteLine($"The {name} is already broken.");
    }
}
interface IInteracticve
{
    void Interact();
}
interface IBreakable
{
    int durability { get; set; }

    void Break();
}
interface ICollectible
{
    bool isCollected { get; set; }
    void Collect();
}