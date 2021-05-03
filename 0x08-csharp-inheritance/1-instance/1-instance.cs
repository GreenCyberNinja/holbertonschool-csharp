using System;

///<summary>class Obj</summary>
class Obj
{
    ///<summary>checks if its an instance of Array</summary>
    public static bool IsInstanceOfArray(object obj)
    {
        return (obj is Array);
    }
}
