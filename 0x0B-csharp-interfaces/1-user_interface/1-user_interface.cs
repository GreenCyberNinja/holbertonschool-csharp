using System;

abstract class Base
{
    public string name { get; set; }

    public override string ToString()
    {
        return ($"{name} is a type {GetType()}");
    }
}
class TestObject : Base, IInteracticve, IBreakable, ICollectible
{
     public int durability { get; set; }
     public bool isCollected { get; set; }

     public void Interact()
     {
        throw new NotImplementedException();
     }
     public void Break()
     {
        throw new NotImplementedException();
     }
     public void Collect()
     {
        throw new NotImplementedException();
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