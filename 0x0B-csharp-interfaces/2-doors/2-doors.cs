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
        Console.WriteLine($"You try to open the {name}. It's locked.");
    }
    public Door(string Name = "Door")
    {
        name = Name;
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