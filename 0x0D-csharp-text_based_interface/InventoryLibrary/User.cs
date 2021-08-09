using System;
using System.Collections;

///<summary>class User inherits from BaseClass</summary>
class User : BaseClass
{
    ///<summary>Name of inventory user</summary>
    public string name { get; set; }

    ///<summary>constructor for user class</summary>
    public User(string name)
    {
        this.name = name;
    }
}